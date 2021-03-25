namespace LB_DES
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtDecryptResult = new System.Windows.Forms.TextBox();
            this.txtCryptResult = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtForDecrypt = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.txtForCrypt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(532, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Išsaugoti užšifruotus duomenis į failą";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(349, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(195, 90);
            this.btnBrowse.TabIndex = 34;
            this.btnBrowse.Text = "Užkrauti užšifruotus \r\nduomenis iš failo";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(250, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 33;
            this.btnGenerate.Text = "Generuoti";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(56, 53);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(191, 20);
            this.txtIV.TabIndex = 32;
            // 
            // txtDecryptResult
            // 
            this.txtDecryptResult.Location = new System.Drawing.Point(9, 131);
            this.txtDecryptResult.Multiline = true;
            this.txtDecryptResult.Name = "txtDecryptResult";
            this.txtDecryptResult.ReadOnly = true;
            this.txtDecryptResult.Size = new System.Drawing.Size(241, 42);
            this.txtDecryptResult.TabIndex = 30;
            // 
            // txtCryptResult
            // 
            this.txtCryptResult.Location = new System.Drawing.Point(6, 131);
            this.txtCryptResult.Multiline = true;
            this.txtCryptResult.Name = "txtCryptResult";
            this.txtCryptResult.ReadOnly = true;
            this.txtCryptResult.Size = new System.Drawing.Size(241, 42);
            this.txtCryptResult.TabIndex = 27;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(7, 71);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(241, 23);
            this.btnDecrypt.TabIndex = 26;
            this.btnDecrypt.Text = "Atšifruoti tekstą";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtForDecrypt
            // 
            this.txtForDecrypt.Location = new System.Drawing.Point(7, 16);
            this.txtForDecrypt.Multiline = true;
            this.txtForDecrypt.Name = "txtForDecrypt";
            this.txtForDecrypt.Size = new System.Drawing.Size(241, 49);
            this.txtForDecrypt.TabIndex = 24;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(56, 27);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(191, 20);
            this.txtKey.TabIndex = 22;
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(6, 71);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(241, 23);
            this.btnCrypt.TabIndex = 21;
            this.btnCrypt.Text = "Užšifruoti tekstą";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtForCrypt
            // 
            this.txtForCrypt.Location = new System.Drawing.Point(6, 19);
            this.txtForCrypt.Multiline = true;
            this.txtForCrypt.Name = "txtForCrypt";
            this.txtForCrypt.Size = new System.Drawing.Size(241, 49);
            this.txtForCrypt.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtIV);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 90);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Raktas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "IV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtForCrypt);
            this.groupBox2.Controls.Add(this.btnCrypt);
            this.groupBox2.Controls.Add(this.txtCryptResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 179);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teksto užšifravimas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtForDecrypt);
            this.groupBox3.Controls.Add(this.btnDecrypt);
            this.groupBox3.Controls.Add(this.txtDecryptResult);
            this.groupBox3.Location = new System.Drawing.Point(289, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 179);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teksto atšifravimas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rezultatas atšifravus tekstą:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rezultatas užšifravus tekstą:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 317);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.MaximumSize = new System.Drawing.Size(573, 356);
            this.MinimumSize = new System.Drawing.Size(573, 356);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LB_DES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtDecryptResult;
        private System.Windows.Forms.TextBox txtCryptResult;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtForDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.TextBox txtForCrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

