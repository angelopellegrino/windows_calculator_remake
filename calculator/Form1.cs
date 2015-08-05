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
        Sqrt, Reciprocal, Percent
    }
    public partial class Form1 : Form
    {

        private decimal total = 0;
        private decimal curVal = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void ShowInput(String n)
        {
            txtDisplay.Text = txtDisplay.Text + n;
            curVal = decimal.Parse(txtDisplay.Text);
        }

        
    }
}
