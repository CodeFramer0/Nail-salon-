namespace Nail_salon
{
    partial class PriceList
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(298, 175);
            label1.TabIndex = 0;
            label1.Text = "Наращивание 2800 💅🏻\r\nМаникюр с покрытием 1800 💅🏻\r\nМаникюр с дизайном 1900 💅🏻\r\nМаникюр без покрытия 1300 💅🏻\r\nУход за ногтями 1000 💅🏻\r\nПедикюр 2400 💅🏻\r\n\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(12, 208);
            button1.Name = "button1";
            button1.Size = new Size(281, 55);
            button1.TabIndex = 1;
            button1.Text = "Вернуться назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PriceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 534);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PriceList";
            Text = "PriceList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}