namespace RSA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.justNumberP = new System.Windows.Forms.TextBox();
            this.justNumberQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.decodingButton = new System.Windows.Forms.Button();
            this.clearMessage = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.rundNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите два простых числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(249, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "p:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(429, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "q:";
            // 
            // justNumberP
            // 
            this.justNumberP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.justNumberP.Location = new System.Drawing.Point(284, 115);
            this.justNumberP.Name = "justNumberP";
            this.justNumberP.Size = new System.Drawing.Size(100, 26);
            this.justNumberP.TabIndex = 1;
            this.justNumberP.Text = "19";
            this.justNumberP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.justNumberP_MouseDown);
            // 
            // justNumberQ
            // 
            this.justNumberQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.justNumberQ.Location = new System.Drawing.Point(464, 115);
            this.justNumberQ.Name = "justNumberQ";
            this.justNumberQ.Size = new System.Drawing.Size(100, 26);
            this.justNumberQ.TabIndex = 1;
            this.justNumberQ.Text = "17";
            this.justNumberQ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.justNumberQ_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ввведите сообщение";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(284, 250);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(246, 26);
            this.message.TabIndex = 2;
            this.message.Text = "Сообщение...";
            this.message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.message_KeyPress);
            this.message.MouseDown += new System.Windows.Forms.MouseEventHandler(this.message_MouseDown);
            // 
            // encryptionButton
            // 
            this.encryptionButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.encryptionButton.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptionButton.ForeColor = System.Drawing.Color.Transparent;
            this.encryptionButton.Location = new System.Drawing.Point(213, 434);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(171, 43);
            this.encryptionButton.TabIndex = 3;
            this.encryptionButton.Text = "ШИФРОВАТЬ";
            this.encryptionButton.UseVisualStyleBackColor = false;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // decodingButton
            // 
            this.decodingButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.decodingButton.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodingButton.ForeColor = System.Drawing.Color.Transparent;
            this.decodingButton.Location = new System.Drawing.Point(434, 434);
            this.decodingButton.Name = "decodingButton";
            this.decodingButton.Size = new System.Drawing.Size(171, 43);
            this.decodingButton.TabIndex = 3;
            this.decodingButton.Text = "РАСШИФРОВАТЬ";
            this.decodingButton.UseVisualStyleBackColor = false;
            this.decodingButton.Click += new System.EventHandler(this.decodingButton_Click);
            // 
            // clearMessage
            // 
            this.clearMessage.BackColor = System.Drawing.Color.Maroon;
            this.clearMessage.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearMessage.Location = new System.Drawing.Point(536, 245);
            this.clearMessage.Name = "clearMessage";
            this.clearMessage.Size = new System.Drawing.Size(89, 35);
            this.clearMessage.TabIndex = 4;
            this.clearMessage.Text = "очистить";
            this.clearMessage.UseVisualStyleBackColor = false;
            this.clearMessage.Click += new System.EventHandler(this.clearMessage_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(238, 309);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(349, 96);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // rundNumbers
            // 
            this.rundNumbers.BackColor = System.Drawing.Color.Gold;
            this.rundNumbers.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rundNumbers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rundNumbers.Location = new System.Drawing.Point(375, 68);
            this.rundNumbers.Name = "rundNumbers";
            this.rundNumbers.Size = new System.Drawing.Size(94, 30);
            this.rundNumbers.TabIndex = 6;
            this.rundNumbers.Text = "РАНДОМ";
            this.rundNumbers.UseVisualStyleBackColor = false;
            this.rundNumbers.Click += new System.EventHandler(this.rundNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 532);
            this.Controls.Add(this.rundNumbers);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.clearMessage);
            this.Controls.Add(this.decodingButton);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.message);
            this.Controls.Add(this.justNumberQ);
            this.Controls.Add(this.justNumberP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox justNumberP;
        private System.Windows.Forms.TextBox justNumberQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.Button decodingButton;
        private System.Windows.Forms.Button clearMessage;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button rundNumbers;
    }
}

