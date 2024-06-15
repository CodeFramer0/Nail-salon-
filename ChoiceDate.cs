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
    public partial class ChoiceDate : Form
    {
        public ChoiceDate()
        {
            InitializeComponent();
        }

        private void ChoiceDate_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                MessageBox.Show($"Вы записаны к мастеру {label1.Text}\nНа {dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {textBox1.Text}");
                return;
            }
            MessageBox.Show($"Вы записаны на {dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {textBox1.Text}");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }
    }
}
