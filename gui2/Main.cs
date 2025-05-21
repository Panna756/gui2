namespace gui2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Control form2 = new Control();
            form2.Show();
            this.Hide();
        }
    }
}
