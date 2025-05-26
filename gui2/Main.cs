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
            ControlForm form2 = new ControlForm();
            form2.Show();
            this.Hide();
        }
    }
}
