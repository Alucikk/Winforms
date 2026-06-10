namespace Calculator11_13
{
    public partial class ConfirmClearForm : Form
    {
        public ConfirmClearForm()
        {
            InitializeComponent();
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
