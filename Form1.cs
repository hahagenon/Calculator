using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {

            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonSIx_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(Display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    Display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    Display.Text = firstOperand.ToString();
                }
            }
            currentOperator = Operators.None;
            operatorChangeFlag = true;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }
        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void buttonMuliply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Multiply; 
            operatorChangeFlag = true;
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

    }
 
}
