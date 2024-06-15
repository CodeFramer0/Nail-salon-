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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masters masters = new();
            this.Hide();
            masters.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Records records = new();
            this.Hide();
            records.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceWithoutMaster serviceWithoutMaster = new();
            this.Hide();
            serviceWithoutMaster.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
