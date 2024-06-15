namespace Nail_salon
{
    partial class AdminServices
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
            button5 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
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
            button2.Location = new Point(649, 275);
            button2.Name = "button2";
            button2.Size = new Size(117, 63);
            button2.TabIndex = 86;
            button2.Text = "Удалить запись";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.Black;
            button5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.AliceBlue;
            button5.Location = new Point(513, 275);
            button5.Name = "button5";
            button5.Size = new Size(130, 63);
            button5.TabIndex = 84;
            button5.Text = "Создать запись";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.Black;
            button4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(764, 587);
            button4.Name = "button4";
            button4.Size = new Size(253, 57);
            button4.TabIndex = 83;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column3 });
            dataGridView2.Location = new Point(23, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(425, 453);
            dataGridView2.TabIndex = 82;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Услуга";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Цена";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 116);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 77;
            label3.Text = "Цена услуги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 77);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 76;
            label2.Text = "Название услуги";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(563, 112);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "руб";
            textBox4.Size = new Size(172, 24);
            textBox4.TabIndex = 75;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(563, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 24);
            textBox2.TabIndex = 74;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(813, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // AdminServices
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 639);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AdminServices";
            Text = "AdminServices";
            Load += AdminServices_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
    }
}