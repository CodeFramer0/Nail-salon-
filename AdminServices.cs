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
    public partial class AdminServices : Form
    {
        public AdminServices()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new();
            admin.Show();
            this.Close();
        }

        private void AdminServices_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            db _db = new();
            var services = _db.GetServices();
            foreach (string[] s in services)
            {
                dataGridView2.Rows.Add(s);
            }
        }
    }
}
