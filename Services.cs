using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nail_salon
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChoiceDate choiceDate = new();
            choiceDate.Show();
            this.Hide();
            switch (label1.Text.ToString())
            {
                case "Ефимова Полина Ярославовна":
                    choiceDate.label1.Text = "Ефимова Полина Ярославовна";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/1.jpg");
                    break;
                case "Королева Полина Ивановна":
                    choiceDate.label1.Text = "Королева Полина Ивановна";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/2.jpg");
                    break;
                case "Фадеева Марьям Никитична":
                    choiceDate.label1.Text = "Фадеева Марьям Никитична";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/3.jpg");
                    break;
                case "Латышева Милана Эмировна":
                    choiceDate.label1.Text = "Латышева Милана Эмировна";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/4.jpg");
                    break;
                case "Сидорова София Романовна":
                    choiceDate.label1.Text = "Сидорова София Романовна";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/5.jpg");
                    break;
                case "Золотарева Анна Львовна":
                    choiceDate.label1.Text = "Золотарева Анна Львовна";
                    choiceDate.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/6.jpg");
                    break;

            }


        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }
    }
}
