namespace Nail_salon
{
    partial class Login
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
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Reem Kufi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(339, 216);
            label1.Name = "label1";
            label1.Size = new Size(248, 44);
            label1.TabIndex = 2;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(317, 399);
            button1.Name = "button1";
            button1.Size = new Size(289, 40);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.Silver;
            textBox2.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(317, 347);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(289, 31);
            textBox2.TabIndex = 8;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(347, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(330, 144);
            label3.Name = "label3";
            label3.Size = new Size(276, 28);
            label3.TabIndex = 11;
            label3.Text = "Студия  ногтевого  сервиса";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Silver;
            maskedTextBox1.Font = new Font("Reem Kufi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(317, 308);
            maskedTextBox1.Mask = "+7(999)-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(289, 31);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(387, 464);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 28);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нет аккаунта?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(984, 561);
            Controls.Add(linkLabel1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Страница авторизации";
            TransparencyKey = Color.FromArgb(192, 0, 0);
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private LinkLabel linkLabel1;
    }
}