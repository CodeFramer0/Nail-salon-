namespace Nail_salon
{
    partial class AdminAccounts
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
            button2 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(521, 245);
            button2.Name = "button2";
            button2.Size = new Size(214, 61);
            button2.TabIndex = 72;
            button2.Text = "Удалить запись";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column3, Column4 });
            dataGridView2.Location = new Point(12, 33);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(425, 453);
            dataGridView2.TabIndex = 68;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "ФИО";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Телефон";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Пароль";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 128);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 67;
            label5.Text = "Пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(552, 125);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Пароль";
            textBox3.Size = new Size(172, 24);
            textBox3.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 95);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 63;
            label3.Text = "Номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 57);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 62;
            label2.Text = "ФИО";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(552, 92);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Телефон";
            textBox4.Size = new Size(172, 24);
            textBox4.TabIndex = 61;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(552, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Боянова Ксения";
            textBox2.Size = new Size(172, 24);
            textBox2.TabIndex = 60;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(751, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.Black;
            button4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(711, 552);
            button4.Name = "button4";
            button4.Size = new Size(200, 44);
            button4.TabIndex = 84;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = false;
            // 
            // AdminAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 596);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AdminAccounts";
            Text = "AdminAccounts";
            Load += AdminAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Button button4;
    }
}