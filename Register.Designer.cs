namespace Nail_salon
{
    partial class Register
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
            linkLabel1 = new LinkLabel();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(316, 471);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(182, 28);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Уже  есть  аккаунт?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Silver;
            maskedTextBox1.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(261, 317);
            maskedTextBox1.Mask = "+7(999)-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(289, 31);
            maskedTextBox1.TabIndex = 19;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(272, 151);
            label3.Name = "label3";
            label3.Size = new Size(276, 28);
            label3.TabIndex = 18;
            label3.Text = "Студия  ногтевого  сервиса";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(289, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.Silver;
            textBox2.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(259, 354);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(290, 31);
            textBox2.TabIndex = 16;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(259, 406);
            button1.Name = "button1";
            button1.Size = new Size(289, 39);
            button1.TabIndex = 15;
            button1.Text = "Создать  аккаунт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Reem Kufi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(280, 210);
            label1.Name = "label1";
            label1.Size = new Size(243, 44);
            label1.TabIndex = 14;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Silver;
            textBox1.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(261, 280);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ФИО";
            textBox1.Size = new Size(290, 31);
            textBox1.TabIndex = 21;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 513);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}