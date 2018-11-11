namespace ALL_LABS
{
    partial class fm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.txInputText = new System.Windows.Forms.RichTextBox();
            this.txOutputText = new System.Windows.Forms.RichTextBox();
            this.txKey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laTxKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbALgoritm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buGenerateKey = new System.Windows.Forms.Button();
            this.buGenerateText = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btEncrypt
            // 
            this.btEncrypt.Location = new System.Drawing.Point(868, 288);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(197, 39);
            this.btEncrypt.TabIndex = 0;
            this.btEncrypt.Text = "Зашифровать";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(868, 349);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(197, 39);
            this.btDecrypt.TabIndex = 1;
            this.btDecrypt.Text = "Расшифровать";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // txInputText
            // 
            this.txInputText.Location = new System.Drawing.Point(528, 38);
            this.txInputText.Name = "txInputText";
            this.txInputText.Size = new System.Drawing.Size(334, 461);
            this.txInputText.TabIndex = 2;
            this.txInputText.Text = "";
            // 
            // txOutputText
            // 
            this.txOutputText.Location = new System.Drawing.Point(1071, 38);
            this.txOutputText.Name = "txOutputText";
            this.txOutputText.Size = new System.Drawing.Size(345, 461);
            this.txOutputText.TabIndex = 3;
            this.txOutputText.Text = "";
            // 
            // txKey
            // 
            this.txKey.Location = new System.Drawing.Point(868, 38);
            this.txKey.Name = "txKey";
            this.txKey.Size = new System.Drawing.Size(197, 120);
            this.txKey.TabIndex = 4;
            this.txKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный текст";
            // 
            // laTxKey
            // 
            this.laTxKey.AutoSize = true;
            this.laTxKey.Location = new System.Drawing.Point(865, 13);
            this.laTxKey.Name = "laTxKey";
            this.laTxKey.Size = new System.Drawing.Size(33, 13);
            this.laTxKey.TabIndex = 6;
            this.laTxKey.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1068, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зашифрованный текст";
            // 
            // cbALgoritm
            // 
            this.cbALgoritm.FormattingEnabled = true;
            this.cbALgoritm.Items.AddRange(new object[] {
            "MAGMA",
            "Diffi-Hellman",
            "CESAR",
            "VIJENER",
            "VIJENER_PSEUDO"});
            this.cbALgoritm.Location = new System.Drawing.Point(12, 38);
            this.cbALgoritm.Name = "cbALgoritm";
            this.cbALgoritm.Size = new System.Drawing.Size(510, 21);
            this.cbALgoritm.TabIndex = 8;
            this.cbALgoritm.SelectedIndexChanged += new System.EventHandler(this.cbALgoritm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Алгоритм";
            // 
            // buGenerateKey
            // 
            this.buGenerateKey.Location = new System.Drawing.Point(868, 164);
            this.buGenerateKey.Name = "buGenerateKey";
            this.buGenerateKey.Size = new System.Drawing.Size(197, 39);
            this.buGenerateKey.TabIndex = 10;
            this.buGenerateKey.Text = "Сгенерировать ключ";
            this.buGenerateKey.UseVisualStyleBackColor = true;
            this.buGenerateKey.Click += new System.EventHandler(this.buGenerateKey_Click);
            // 
            // buGenerateText
            // 
            this.buGenerateText.Location = new System.Drawing.Point(868, 224);
            this.buGenerateText.Name = "buGenerateText";
            this.buGenerateText.Size = new System.Drawing.Size(197, 38);
            this.buGenerateText.TabIndex = 12;
            this.buGenerateText.Text = "Сгенерировать текст";
            this.buGenerateText.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 65);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(510, 432);
            this.webBrowser.TabIndex = 13;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 505);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(1404, 136);
            this.rtbLog.TabIndex = 14;
            this.rtbLog.Text = "";
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 653);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.buGenerateText);
            this.Controls.Add(this.buGenerateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbALgoritm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laTxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txKey);
            this.Controls.Add(this.txOutputText);
            this.Controls.Add(this.txInputText);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btEncrypt);
            this.Name = "fm";
            this.Text = "All labs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.RichTextBox txInputText;
        private System.Windows.Forms.RichTextBox txOutputText;
        private System.Windows.Forms.RichTextBox txKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laTxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbALgoritm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buGenerateKey;
        private System.Windows.Forms.Button buGenerateText;
        private System.Windows.Forms.WebBrowser webBrowser;
        public System.Windows.Forms.RichTextBox rtbLog;
    }
}

