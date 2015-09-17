using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{

    public enum Operator
    {
        None, Add, Minus, Divide, Multiply,
        Sqrt, Inverse, Percent
    }
    public partial class Form1 : Form
    {

/* Using decimal to allow for more precision over double.
 * May be changed later on depending on the performance 
 * of the calculator. If it is too slow, the switch to
 * double may be warranted and more efficient.
 */
        private decimal total = 0;
        private decimal curVal = 0;
        private Operator curOperator;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


// Configuring the number buttons to display text on click.
        private void btn1_Click(object sender, EventArgs e)
        {
            ShowInput(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowInput(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowInput(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowInput(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowInput(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowInput(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowInput(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowInput(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowInput(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowInput(btn0.Text);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + '.';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            curOperator = Operator.None;
            txtDisplay.Clear();
            total = 0;
        }

// Code for handling the display of numbers.
        private void ShowInput(String n)
        {
            txtDisplay.Text = txtDisplay.Text + n;
            curVal = decimal.Parse(txtDisplay.Text);
        }


// Operators.
        private void btnPlus_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Add);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Minus);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Divide);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Multiply);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Sqrt);
            evaluate();
            txtDisplay.Text = Convert.ToString(total);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            applyOperator(Operator.Percent);
        }

        //private void btnInverse_Click(object sender, EventArgs e)
        //{
        //    applyOperator(Operator.Inverse);
        //    
        //}

        //The Equals button.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            evaluate();
            txtDisplay.Text = Convert.ToString(total);
        }

        //switch statement to apply the correct operrator
        private void evaluate()
        {
            switch (curOperator)
            {
                case Operator.Add:
                    total += curVal;
                    break;
                case Operator.Minus:
                    total -= curVal;
                    break;
                case Operator.Multiply:
                    total *= curVal;
                    break;
                case Operator.Divide:
                    total /= curVal;
                    break;
                case Operator.Sqrt:
                    double squareRoot = System.Convert.ToDouble(curVal);
                    double tmpTotal = Math.Sqrt(squareRoot);
                    total = System.Convert.ToDecimal(tmpTotal);
                    break;
                case Operator.Percent:
                    total = curVal / 100;
                    break;
                //case Operator.Inverse:
                // toDo: code inverse.
                case Operator.None:
                    break;
            }
            curVal = 0;
            curOperator = Operator.None;
        }

        private void applyOperator(Operator op)
        {
            if (curOperator != Operator.None)
            {
                evaluate();
            }
            else
            {
                total = decimal.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            curOperator = op;
        }

        private void ShowIput(String n)
        {
            txtDisplay.Text = txtDisplay.Text + n;
            curVal = decimal.Parse(txtDisplay.Text);
        }

        
    }
}
