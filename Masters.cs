
namespace Nail_salon
{
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Masters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Tag.ToString();
            Services services = new();
            services.Show();
            this.Hide();
            switch (b.Tag.ToString())
            {
                case "1":
                    services.label1.Text = "Ефимова Полина Ярославовна";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/1.jpg");
                    break;
                case "2":
                    services.label1.Text = "Королева Полина Ивановна";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/2.jpg");
                    break;
                case "3":
                    services.label1.Text = "Фадеева Марьям Никитична";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/3.jpg");
                    break;
                case "4":
                    services.label1.Text = "Латышева Милана Эмировна";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/4.jpg");
                    break;
                case "5":
                    services.label1.Text = "Сидорова София Романовна";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/5.jpg");
                    break;
                case "6":
                    services.label1.Text = "Золотарева Анна Львовна";
                    services.pictureBox1.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "asserts/6.jpg");
                    break;

            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }
    }
}
