using Microsoft.Data.Sqlite;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            using (var connection = new SqliteConnection("Data Source=usersdata.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"select * from [Carts]";
                // command.Parameters.AddWithValue("phone", phone);

                using (SqliteDataReader reader = command.ExecuteReader())
                {





                    List<string[]> data = new List<string[]>();

                    while (reader.Read())
                    {

                        data.Add(new string[4]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();






                    }

                    reader.Close();

                    connection.Close();

                    foreach (string[] s in data)
                    {
                        //clientsGrid.Rows.Add(s);
                        dataGridView1.Rows.Add(s);
                    }
                }
            }
        }
    }
}
