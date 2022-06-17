using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void NumEvent(object sender, EventArgs e)   //numerical buttons
        {
            if (txtResult.Text == "0" || operandPerformed)  
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e) //operator function buttons
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();break;
                default:break;
            }
            result = Double.Parse(txtResult.Text);
            operand = newOperand;
        }
        private void button10_Click(object sender, EventArgs e) //CE button
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }
        private void button17_Click(object sender, EventArgs e) //C button
        {
            txtResult.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e) //equals button
        {
            lbResult.Text = "";
            operandPerformed = true;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }
            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";

        }
        private void button14_Click(object sender, EventArgs e) //decemal point button
        {
            if (!operandPerformed && !txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
            else if (operandPerformed)
            {
                txtResult.Text = "0";
            }
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
            operandPerformed = false;
        }

        private void backspace_Click(object sender, EventArgs e)    //Backspace button
        {
            if (String.Compare(txtResult.Text, " ") < 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1 + 1);
            }
            else
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }
    }
}
