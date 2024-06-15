



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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAccounts adminAccounts = new();
            adminAccounts.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminServices adminServices = new();
            this.Hide();
            adminServices.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminAnalytics adminAnalytics = new();
            this.Hide();
            adminAnalytics.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminSchedule adminSchedule = new();
            adminSchedule.Show();
            this.Hide();
        }
    }
}
