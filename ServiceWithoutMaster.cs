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
    public partial class ServiceWithoutMaster : Form
    {
        public ServiceWithoutMaster()
        {
            InitializeComponent();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoiceDate choiceDate = new();
            choiceDate.label1.Visible = false;
            choiceDate.label3.Visible = false;
            choiceDate.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }
    }
}
