using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nail_salon
{
    public partial class Serivce : Form
    {
        public Serivce()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NarashivaniePicture.WaitOnLoad = false;
            PokritiePicture.WaitOnLoad = false;
            DezinePicture.WaitOnLoad = false;
            BezPokritiaPicture.WaitOnLoad = false;
            YhodzanoktiamiPicture.WaitOnLoad = false;
            PedicurePicture.WaitOnLoad = false;

            NarashivaniePicture.LoadAsync(@"static/НАРАЩИВАНИЕ.jpg");
            PokritiePicture.LoadAsync(@"static/ПОКРЫТИЕ.jpg");
            DezinePicture.LoadAsync(@"static/ДИЗАЙН.jpg");
            BezPokritiaPicture.LoadAsync(@"static/БЕЗ ПОКРЫТИЯ.jpg");
            YhodzanoktiamiPicture.LoadAsync(@"static/УХОД.jpg");
            PedicurePicture.LoadAsync(@"static/ПЕДИКЮР.jpg");

            Cart.Text = @"";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void price_list_view(object sender, EventArgs e)
        {
            Form f2 = new Nail_salon.PriceList();
            f2.Show();
            Hide();
        }
        private void add_cart(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32((sender as Button).Tag);
            switch (product_id)
            {
                case 1:
                    {
                        button1.Enabled = false;
                        Cart.Text = Cart.Text + "\nНаращивание 2800 ₽";
                        WriteCart();
                        break;
                    }
                case 2:
                    {
                        button2.Enabled = false;
                        Cart.Text = Cart.Text + "\nМаникюр с покрытием 1800 ₽";
                        break;
                    }
                case 3:
                    {
                        button3.Enabled = false;
                        Cart.Text = Cart.Text + "\nМаникюр с дизайном 1900 ₽";
                        break;
                    }
                case 4:
                    {
                        button4.Enabled = false;
                        Cart.Text = Cart.Text + "\nМаникюр без покрытия 1300 ₽";
                        break;
                    }
                case 5:
                    {
                        button5.Enabled = false;
                        Cart.Text = Cart.Text + "\nУход за ногтями 1000 ₽";
                        break;
                    }
                case 6:
                    {
                        button6.Enabled = false;
                        Cart.Text = Cart.Text + "\nПедикюр 2400 ₽";
                        break;
                    }


            }
        }

        private void WriteCart()
        {
            using (var connection = new SqliteConnection("Data Source=usersdata.db"))
            {
                connection.Open();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string phone= "";
            string name = "";
            string items = Cart.Text.ToString();
            string date = dateTimePicker1.Text.ToString();
            int id = 0;
           
            using (var connection = new SqliteConnection("Data Source=usersdata.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"select [active_phone] from [Config]";
               // command.Parameters.AddWithValue("phone", phone);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            phone = (string)reader.GetValue(0);
                            
                           



                        }
                        reader.Close();
                        connection.Close();


                    }
                    
                }
                command.CommandText = $"select [name] from [Users] where phone= @phone";
                command.Parameters.AddWithValue("phone", phone);
                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            name = (string)reader.GetValue(0);





                        }
                        reader.Close();
                        connection.Close();


                    }

                }



                connection.Open();
                command.CommandText = $"select [id] from [Users] where phone = {phone}";
                command.Parameters.AddWithValue("phone", phone);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            id = (int)reader.GetInt64(0);





                        }
                        reader.Close();


                    }

                }










                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Carts (id,items,date) VALUES (@id,@items,@date)";
                insertCmd.Parameters.AddWithValue("id", id);
                insertCmd.Parameters.AddWithValue("items", items);
                insertCmd.Parameters.AddWithValue("date", date);
                insertCmd.ExecuteNonQuery();
                MessageBox.Show($"Вы успешно записались к мастеру на {date}");
             
            }
        }
    }
}