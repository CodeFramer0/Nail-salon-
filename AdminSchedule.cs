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
    public partial class AdminSchedule : Form
    {
        public AdminSchedule()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new();
            admin.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminSchedule_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add('1', "Ефимова Полина Ярославовна", "11:00-16:00");
            dataGridView1.Rows.Add('2', "Королева Полина Ивановна", "16:00-18:00");
            dataGridView1.Rows.Add('3', "Фадеева Марьям Никитична", "16:00-18:00");
            dataGridView1.Rows.Add('4', "Латышева Милана Эмировна", "18:30-20:30");
        }
    }
}
