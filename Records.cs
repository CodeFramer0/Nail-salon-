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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/star-fill.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/star-fill.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/star-fill.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/star-fill.png");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/star-fill.png");
        }
    }
}
