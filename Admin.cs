



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

        }
        
    }
}
