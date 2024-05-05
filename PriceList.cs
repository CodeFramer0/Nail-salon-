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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Nail_salon.Serivce();
            f2.Show();
            this.Close();
        }
    }
}
