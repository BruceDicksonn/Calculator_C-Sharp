using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dangl.Calculator;

namespace WindowsFormsAppCalculadora
{
    public partial class Form1 : Form
    {

        private string expression = "";
        private string currentDisplayValue = "0";
        private string currentNumber = "";
        private string lastNumber = "";
        private double? lastResult = null;
        private string lastOperator = "";
        private string currentOperator = "";
        float defaultFontSize;


        public string Expression { get => expression; set => expression = value; }
        public string CurrentDisplayValue { get => currentDisplayValue; set => currentDisplayValue = value; }
        public string LastNumber { get => lastNumber; set => lastNumber = value; }
        public string LastOperator { get => lastOperator; set => lastOperator = value; }
        public double? LastResult { get => lastResult; set => lastResult = value; }
        public string CurrentNumber { get => currentNumber; set => currentNumber = value; }
        public string CurrentOperator { get => currentOperator; set => currentOperator = value; }
        public float DefaultFontSize { get => defaultFontSize; set => defaultFontSize = value; }

        public Form1()
        {
            InitializeComponent();

            DefaultFontSize = display.Font.Size;

            foreach (Control  c in this.Controls)
            {
                if(c is Button)
                {
                    c.Click += btn_Click;
                    c.TabStop = false;
                }
            }

        }

        private void updateDisplayExpression()
        {
            displayExpression.Text = expression;
        }

        private void updateDisplay()
        {
            display.Text = currentDisplayValue == string.Empty ? "0" : currentDisplayValue;
        }

        private bool validateDisplay(string value)
        {
            if (display.Text.Length == 21) return false;
            if (display.Text.Length == 1 && display.Text == "0" && value == "0") return false;
            if (display.Text.Length == 1 && display.Text == "0")
            {
                expression = "";
                currentDisplayValue = "";
            }

            return true;
        }

        private string validateExpression(string tagOperator)
        {

            if (expression.Contains("="))
            {
                if(tagOperator == "=")
                {
                    expression = $"{ LastResult } { LastOperator } { CurrentNumber }";
                    updateDisplayExpression();
                } else
                {
                    expression = $"{ LastNumber }";
                    return expression;
                }
            }
            return expression;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button target = (Button) sender;

            if ( !validateDisplay(target.Text) ) return;
       
            if ( display.Text.Length >= 12 )
            {
                float fontSize = display.Font.Size - 1.33f;
                display.Font = new Font(display.Font.FontFamily, fontSize);
            }


            if (target.Tag != null)
            {

                if(CurrentOperator != string.Empty)
                {
                    expression = expression.Substring(0, expression.Length - 3);
                }


                if (CurrentOperator == "=")
                {
                    expression = $"{LastResult}";
                }

                if(CurrentOperator != string.Empty && CurrentOperator != "=" && currentDisplayValue != string.Empty)
                {
                    double res = Calculator.Calculate($"{LastNumber}{CurrentOperator}{CurrentNumber}").Result;
                    expression = $"{res}";
                    CurrentNumber = res.ToString();
                    currentDisplayValue = CurrentNumber;
                    updateDisplay();
                }


                expression += $" { target.Tag.ToString() } ";
                currentDisplayValue = "";
                LastNumber = CurrentNumber;
                CurrentNumber = "";
                CurrentOperator = target.Tag.ToString();
                updateDisplayExpression();
                return;
            }

            expression += $"{ target.Text }";
            CurrentNumber += $"{ target.Text }";
            currentDisplayValue += target.Text;

            updateDisplay();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            expression = string.Empty;
            currentDisplayValue = string.Empty;
            displayExpression.Text = string.Empty;
            CurrentNumber = string.Empty;
            LastNumber = string.Empty;
            CurrentOperator = "";
            LastOperator = "";
            LastResult = null;
            updateDisplay();
            updateDisplayExpression();
            display.Font = new Font(display.Font.FontFamily, DefaultFontSize);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if ( expression.Contains("=") )
            {
                // preserves the last value for the next operation
                expression = "";
                updateDisplayExpression();
                expression = $"{ LastResult }";

                return;
            }

            int range  = expression != string.Empty ? (expression.Length - 1) : 0;
            expression = expression.Substring(0, range);
            updateDisplay();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (CurrentNumber == string.Empty)
            {
                CurrentNumber = LastNumber;
                expression = $"{LastNumber}{LastOperator}{CurrentNumber}";
            } else
            {
                expression = validateExpression("=");
                displayExpression.Text = expression += " = ";
            }

            CalculationResult result = Calculator.Calculate(expression);

            LastResult = result.Result;
            LastOperator = CurrentOperator != "=" ? CurrentOperator : LastOperator ;
            CurrentOperator = "=";
            currentDisplayValue = result.Result.ToString();

            updateDisplay();
        }
    }
}
