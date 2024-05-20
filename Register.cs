

using System.Diagnostics;

namespace Nail_salon
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(maskedTextBox1.Text);
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Поле ФИО является обязательным для заполнения");
                return;
            }         

            if (maskedTextBox1.Text == "+7(   )-   -")
            {
                MessageBox.Show("Поле Телефон является обязательным для заполнения");
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Поле Пароль является обязательным для заполнения");
                return;
            }

            if (textBox2.Text.Trim().Length<7)
            {
                MessageBox.Show("Поле Пароль не может содержать меньше 7 символов");
                return;
            }    

            db db = new();
            Hashing hashing = new();
            bool isAdmin = false;
            string fio = textBox1.Text.ToString();
            string phone = maskedTextBox1.Text.ToString();
            string password = hashing.hashPassword(textBox2.Text.ToString(),5);
            string result = db.createUser(fio,phone,password,isAdmin);
            MessageBox.Show(result);
        }
    }
}
