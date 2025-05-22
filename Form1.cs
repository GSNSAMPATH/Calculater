using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private string input = "";
        private double result = 0;
        private string operation = "";
        private bool isSecondNumber = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            string buttonText = button.Text;

            // If a number button is clicked
            if (double.TryParse(buttonText, out _))
            {
                input += buttonText;

                if (isSecondNumber)
                {
                    // Display second number on the second line
                    textBoxDisplay.Text = $"{result} {operation}\r\n{input}";
                }
                else
                {
                    textBoxDisplay.Text = input;
                }
            }
            // If "C" (Clear) is clicked
            else if (buttonText == "C")
            {
                input = "";
                result = 0;
                operation = "";
                isSecondNumber = false;
                textBoxDisplay.Text = "";
            }
            // If "=" (Equals) is clicked
            else if (buttonText == "=")
            {
                if (double.TryParse(input, out double secondOperand))
                {
                    switch (operation)
                    {
                        case "+": result += secondOperand; break;
                        case "-": result -= secondOperand; break;
                        case "*": result *= secondOperand; break;
                        case "/": result /= secondOperand; break;
                    }
                    textBoxDisplay.Text = $"{result}";
                    input = "";
                    operation = "";
                    isSecondNumber = false;
                }
            }
            // If an operator (+, -, *, /) is clicked
            else
            {
                if (double.TryParse(input, out double firstOperand))
                {
                    result = firstOperand;
                    input = "";
                    operation = buttonText;
                    isSecondNumber = true;

                    // Display first number and operator on first line
                    textBoxDisplay.Text = $"{result} {operation}\r\n";
                }
            }
        }
    }
}
