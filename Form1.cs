namespace MyForm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox1.Text))
            {
                MessageBox.Show("Введiть своє iм'я, поле не може бути пустим");
            }
            else
            {
                MessageBox.Show("Доброго дня, " + txtBox1.Text);
            }
        }
    }
}
