using System.Globalization;
namespace Calculator11_13
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation;
        private bool isOperationSelected;
        public Form1()
        {
            InitializeComponent();
            firstNumber = 0;
            operation = "";
            isOperationSelected = false;
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (isOperationSelected == true)
            {
                lblDisplay.Text = "";
                isOperationSelected = false;
            }
            string buttonText = ((Button)sender).Text;

            if (lblDisplay.Text == "0" && buttonText != ".")
            {
                lblDisplay.Text = buttonText;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + buttonText;
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            operation = "+";
            isOperationSelected = true;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            operation = "-";
            isOperationSelected = true;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            operation = "*";
            isOperationSelected = true;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            operation = "/";
            isOperationSelected = true;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            double result = 0;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    lblDisplay.Text = "Error.Не дiлiть на 0";
                    return;
                }
                result = firstNumber / secondNumber;
            }
            lblDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}