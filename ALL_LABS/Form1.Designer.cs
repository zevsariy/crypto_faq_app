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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbALgoritm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buGenerateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEncrypt
            // 
            this.btEncrypt.Location = new System.Drawing.Point(376, 324);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(197, 39);
            this.btEncrypt.TabIndex = 0;
            this.btEncrypt.Text = "Зашифровать";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(376, 390);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(197, 39);
            this.btDecrypt.TabIndex = 1;
            this.btDecrypt.Text = "Расшифровать";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // txInputText
            // 
            this.txInputText.Location = new System.Drawing.Point(12, 36);
            this.txInputText.Name = "txInputText";
            this.txInputText.Size = new System.Drawing.Size(343, 282);
            this.txInputText.TabIndex = 2;
            this.txInputText.Text = "";
            // 
            // txOutputText
            // 
            this.txOutputText.Location = new System.Drawing.Point(596, 36);
            this.txOutputText.Name = "txOutputText";
            this.txOutputText.Size = new System.Drawing.Size(343, 282);
            this.txOutputText.TabIndex = 3;
            this.txOutputText.Text = "";
            // 
            // txKey
            // 
            this.txKey.Location = new System.Drawing.Point(376, 36);
            this.txKey.Name = "txKey";
            this.txKey.Size = new System.Drawing.Size(197, 111);
            this.txKey.TabIndex = 4;
            this.txKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 9);
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
            this.cbALgoritm.Location = new System.Drawing.Point(376, 286);
            this.cbALgoritm.Name = "cbALgoritm";
            this.cbALgoritm.Size = new System.Drawing.Size(197, 21);
            this.cbALgoritm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Алгоритм";
            // 
            // buGenerateKey
            // 
            this.buGenerateKey.Location = new System.Drawing.Point(376, 162);
            this.buGenerateKey.Name = "buGenerateKey";
            this.buGenerateKey.Size = new System.Drawing.Size(197, 39);
            this.buGenerateKey.TabIndex = 10;
            this.buGenerateKey.Text = "Сгенерировать";
            this.buGenerateKey.UseVisualStyleBackColor = true;
            this.buGenerateKey.Click += new System.EventHandler(this.buGenerateKey_Click);
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 441);
            this.Controls.Add(this.buGenerateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbALgoritm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbALgoritm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buGenerateKey;
    }
}

