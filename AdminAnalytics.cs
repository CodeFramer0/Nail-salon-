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
    public partial class AdminAnalytics : Form
    {
        public AdminAnalytics()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void AdminAnalit_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new();
            admin.Show();
            this.Close();
        }

        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            db _db = new();
            var services = _db.GetAnalytics();
            foreach (string[] s in services)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
