namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You voted for:\n" + cboMovie.SelectedItem);
        }
    }
}