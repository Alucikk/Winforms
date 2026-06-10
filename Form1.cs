using System.Globalization;
using System.Drawing;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            radioOn.Checked = true;
        }
        private void radioOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOn.Checked == true)
            {
                foreach (Control control in tlpButtonsPanel.Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = true; 
                    }
                }
                this.KeyPreview = true; 
            }
        }
        private void radioOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOff.Checked == true)
            {
                foreach (Control control in tlpButtonsPanel.Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false; 
                    }
                }
                this.KeyPreview = false; 
                lblDisplay.Text = "0";   
            }
        }
        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            int length = lblDisplay.Text.Length;
            if (length >= 0 && length <= 3)
            {
                lblDisplay.ForeColor = Color.Black;
            }
            else if (length >= 4 && length <= 8)
            {
                lblDisplay.ForeColor = Color.DarkGreen;
            }
            else if (length > 8)
            {
                lblDisplay.ForeColor = Color.DarkRed;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                btnNumber_Click(btn0, EventArgs.Empty); 
            }
            if (e.KeyCode == Keys.D1)
            {
                btnNumber_Click(btn1, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D2)
            {
                btnNumber_Click(btn2, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D3)
            {
                btnNumber_Click(btn3, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D4)
            {
                btnNumber_Click(btn4, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D5)
            {
                btnNumber_Click(btn5, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D6)
            {
                btnNumber_Click(btn6, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D7)
            {
                btnNumber_Click(btn7, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D8)
            {
                btnNumber_Click(btn8, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D9)
            {
                btnNumber_Click(btn9, EventArgs.Empty);
            }
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
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 0 && lblDisplay.Text != "0")
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
            if (lblDisplay.Text == "" || lblDisplay.Text == "-")
            {
                lblDisplay.Text = "0";
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(lblDisplay.Text, CultureInfo.InvariantCulture);
            double result = currentNumber / 100;

            lblDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
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