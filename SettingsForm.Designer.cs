namespace BorsaCini
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuySignalTitleText = new System.Windows.Forms.TextBox();
            this.SellSignalTitleText = new System.Windows.Forms.TextBox();
            this.SenderText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ApiKeyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SecretKeyText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuyEmailAdressText = new System.Windows.Forms.TextBox();
            this.BuyEmailAdressPwText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SellEmailAdressText = new System.Windows.Forms.TextBox();
            this.SellEmailAdressPwText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CoinText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TradeCoinText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy Signal Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sell Signal Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BuySignalTitleText
            // 
            this.BuySignalTitleText.Location = new System.Drawing.Point(171, 42);
            this.BuySignalTitleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuySignalTitleText.Name = "BuySignalTitleText";
            this.BuySignalTitleText.Size = new System.Drawing.Size(340, 26);
            this.BuySignalTitleText.TabIndex = 2;
            // 
            // SellSignalTitleText
            // 
            this.SellSignalTitleText.Location = new System.Drawing.Point(170, 93);
            this.SellSignalTitleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellSignalTitleText.Name = "SellSignalTitleText";
            this.SellSignalTitleText.Size = new System.Drawing.Size(340, 26);
            this.SellSignalTitleText.TabIndex = 3;
            // 
            // SenderText
            // 
            this.SenderText.Location = new System.Drawing.Point(171, 148);
            this.SenderText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SenderText.Name = "SenderText";
            this.SenderText.Size = new System.Drawing.Size(340, 26);
            this.SenderText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 639);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(495, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApiKeyText
            // 
            this.ApiKeyText.Location = new System.Drawing.Point(171, 200);
            this.ApiKeyText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApiKeyText.Name = "ApiKeyText";
            this.ApiKeyText.Size = new System.Drawing.Size(340, 26);
            this.ApiKeyText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Api Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Secret";
            // 
            // SecretKeyText
            // 
            this.SecretKeyText.Location = new System.Drawing.Point(170, 255);
            this.SecretKeyText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecretKeyText.Name = "SecretKeyText";
            this.SecretKeyText.Size = new System.Drawing.Size(340, 26);
            this.SecretKeyText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buy Email Adres";
            // 
            // BuyEmailAdressText
            // 
            this.BuyEmailAdressText.Location = new System.Drawing.Point(170, 303);
            this.BuyEmailAdressText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyEmailAdressText.Name = "BuyEmailAdressText";
            this.BuyEmailAdressText.Size = new System.Drawing.Size(340, 26);
            this.BuyEmailAdressText.TabIndex = 12;
            // 
            // BuyEmailAdressPwText
            // 
            this.BuyEmailAdressPwText.Location = new System.Drawing.Point(171, 364);
            this.BuyEmailAdressPwText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyEmailAdressPwText.Name = "BuyEmailAdressPwText";
            this.BuyEmailAdressPwText.Size = new System.Drawing.Size(340, 26);
            this.BuyEmailAdressPwText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sell Email Adress";
            // 
            // SellEmailAdressText
            // 
            this.SellEmailAdressText.Location = new System.Drawing.Point(170, 419);
            this.SellEmailAdressText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellEmailAdressText.Name = "SellEmailAdressText";
            this.SellEmailAdressText.Size = new System.Drawing.Size(340, 26);
            this.SellEmailAdressText.TabIndex = 16;
            // 
            // SellEmailAdressPwText
            // 
            this.SellEmailAdressPwText.Location = new System.Drawing.Point(169, 476);
            this.SellEmailAdressPwText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellEmailAdressPwText.Name = "SellEmailAdressPwText";
            this.SellEmailAdressPwText.Size = new System.Drawing.Size(340, 26);
            this.SellEmailAdressPwText.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 539);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Coin";
            // 
            // CoinText
            // 
            this.CoinText.Location = new System.Drawing.Point(170, 533);
            this.CoinText.Name = "CoinText";
            this.CoinText.Size = new System.Drawing.Size(342, 26);
            this.CoinText.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 592);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Trade";
            // 
            // TradeCoinText
            // 
            this.TradeCoinText.Location = new System.Drawing.Point(170, 586);
            this.TradeCoinText.Name = "TradeCoinText";
            this.TradeCoinText.Size = new System.Drawing.Size(339, 26);
            this.TradeCoinText.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TradeCoinText);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CoinText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SellEmailAdressPwText);
            this.groupBox1.Controls.Add(this.SellEmailAdressText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BuyEmailAdressPwText);
            this.groupBox1.Controls.Add(this.BuyEmailAdressText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SecretKeyText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ApiKeyText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SenderText);
            this.groupBox1.Controls.Add(this.SellSignalTitleText);
            this.groupBox1.Controls.Add(this.BuySignalTitleText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(525, 760);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 702);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuySignalTitleText;
        private System.Windows.Forms.TextBox SellSignalTitleText;
        private System.Windows.Forms.TextBox SenderText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ApiKeyText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SecretKeyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BuyEmailAdressText;
        private System.Windows.Forms.TextBox BuyEmailAdressPwText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SellEmailAdressText;
        private System.Windows.Forms.TextBox SellEmailAdressPwText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CoinText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TradeCoinText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}