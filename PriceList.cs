



namespace Nail_salon
{
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Nail_salon.Serivce();
            f2.Show();
            this.Close();
        }
    }
}
