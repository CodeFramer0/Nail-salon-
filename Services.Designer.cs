namespace Nail_salon
{
    partial class Services
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label2 = new Label();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(988, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(21, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 402);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 30;
            label1.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(341, 44);
            label3.TabIndex = 33;
            label3.Text = "Выбранный мастер:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(652, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(240, 21);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Педикюр SMART*** и гель-лак (2300₽)\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(652, 194);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(253, 21);
            checkBox2.TabIndex = 36;
            checkBox2.Text = "Обработка пальчиков и гель-лак (1800₽)\r\n";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(652, 222);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(317, 21);
            checkBox3.TabIndex = 37;
            checkBox3.Text = "Обработка пальчиков и стопы без покрытия (1800₽)\r\n";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(652, 250);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(271, 21);
            checkBox4.TabIndex = 38;
            checkBox4.Text = "Обработка пальчиков без покрытия (1100₽)\r\n";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(652, 279);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(160, 21);
            checkBox5.TabIndex = 39;
            checkBox5.Text = "Обработка стопы (800₽)\r\n";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(652, 307);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(153, 21);
            checkBox6.TabIndex = 40;
            checkBox6.Text = "Сложные стопы (300₽)\r\n";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(641, 105);
            label2.Name = "label2";
            label2.Size = new Size(134, 44);
            label2.TabIndex = 42;
            label2.Text = "Услуги:";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.Black;
            button5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.AliceBlue;
            button5.Location = new Point(641, 447);
            button5.Name = "button5";
            button5.Size = new Size(462, 45);
            button5.TabIndex = 55;
            button5.Text = "Выбрать дату и время";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.arrow_back_long_svgrepo_com;
            pictureBox5.ImageLocation = "";
            pictureBox5.Location = new Point(21, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(84, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 143;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 721);
            Controls.Add(pictureBox5);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Services";
            Text = "Services";
            Load += Services_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label2;
        private Button button5;
        public Label label1;
        public PictureBox pictureBox1;
        private PictureBox pictureBox5;
    }
}