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
    public partial class AdminAccounts : Form
    {
        public AdminAccounts()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dataGridView2.Rows.Clear();
            db _db = new();
            var clients = _db.GetUsers();
            foreach (string[] s in clients)
            {
                dataGridView2.Rows.Add(s);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminAccounts_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new();
            admin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
