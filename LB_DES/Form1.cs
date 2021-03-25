using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace LB_DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Encrypt(string message, string key, byte[] IV)
        {
            if (key.Length == 8)
            {
                // Encode message and password
                byte[] messageBytes = Encoding.ASCII.GetBytes(message);
                byte[] passwordBytes = Encoding.ASCII.GetBytes(key);

                // Set encryption settings -- Use password for both key and init. vector
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, IV);
                CryptoStreamMode mode = CryptoStreamMode.Write;

                // Set up streams and encrypt
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
                cryptoStream.Write(messageBytes, 0, messageBytes.Length);
                cryptoStream.FlushFinalBlock();

                // Read the encrypted message from the memory stream
                byte[] encryptedMessageBytes = new byte[memStream.Length];
                memStream.Position = 0;
                memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

                // Encode the encrypted message as base64 string
                string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

                return encryptedMessage;
            }
            else throw new Exception("Raktas turi buti 8-bitu");
        }


        public static string Decrypt(string encryptedMessage, string key, byte[] IV)
        {
            // Convert encrypted message and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = Encoding.ASCII.GetBytes(key);

            // Set encryption settings -- Use password for both key and init. vector
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, IV);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and decrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read decrypted message from memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            // Encode deencrypted binary data to base64 string
            string message = Encoding.ASCII.GetString(decryptedMessageBytes);

            return message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Encoding encoding = Encoding.GetEncoding("437");

                byte[] IV = encoding.GetBytes(txtIV.Text);

                string text = txtForCrypt.Text;
                string key = txtKey.Text;

                string encryptedString = Encrypt(text, key, IV);

                txtCryptResult.Text = encryptedString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Encoding encoding = Encoding.GetEncoding("437");
                byte[] IV = encoding.GetBytes(txtIV.Text);

                string text = txtForDecrypt.Text;
                string key = txtKey.Text;

                string decryptedString = Decrypt(text, key, IV);
                txtDecryptResult.Text = decryptedString;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "File selection";
            OFD.InitialDirectory = @"C:\";
            OFD.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(OFD.FileName);
                txtForDecrypt.Text = lines[0];
                txtIV.Text = lines[1];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var random = new Random();

            byte[] IV = new byte[8];

            random.NextBytes(IV);

            Encoding encoding = Encoding.GetEncoding("437");

            txtIV.Text = encoding.GetString(IV);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("out.txt", txtCryptResult.Text + Environment.NewLine + txtIV.Text);

            MessageBox.Show("Duomenys išsaugoti out.txt faile");
        }
    }
}
