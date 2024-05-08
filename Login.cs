using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Nail_salon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var name = "123";
            var phone = "123";


            using (var connection = new SqliteConnection("Data Source=usersdata.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"select [id] from [Users] where phone = @phone";
                command.Parameters.AddWithValue("phone", phone);


                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                int id = reader.GetInt16(0);



                            }


                        }


                        else
                        {
                            reader.Close();
                            var insertCmd = connection.CreateCommand();
                            insertCmd.CommandText = "INSERT INTO Users (name,phone) VALUES (@name,@phone)";
                            insertCmd.Parameters.AddWithValue("phone", phone);
                            insertCmd.Parameters.AddWithValue("name", name);
                            insertCmd.ExecuteNonQuery();








                            insertCmd.CommandText = "update Config set active_phone=@active_phone";
                            insertCmd.Parameters.AddWithValue("active_phone", phone);
                            insertCmd.ExecuteNonQuery();

                        }
                        Debug.WriteLine(name);
                        if (name == "admin")
                        {
                            Form f2 = new Nail_salon.Admin();
                            f2.Show();
                            Hide();
                        }
                        else
                        {
                            Form f2 = new Nail_salon.Serivce();
                            f2.Show();
                            Hide();
                        }
                    }
                }

                catch (Exception error)
                {
                    Debug.WriteLine(error.Message);
                    MessageBox.Show("Ошибка");

                }




            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

