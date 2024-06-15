


namespace Nail_salon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            db db = new();
            db.createTables();
        }


        private void button1_Click(object sender,EventArgs e)
        {
            if (textBox2.Text == "admin")
            {
                Admin admin = new();
                admin.Show();
                this.Hide();
                return;
            }
            Menu menu = new();
            menu.Show();
            this.Hide();
        }


        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new();
            this.Hide();
            form.Show();
        }
    }
}

