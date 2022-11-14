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
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbxDisplayResult.Text == "0" || (isOperationPerformed ) )
               tbxDisplayResult.Clear();
               isOperationPerformed = false;
               Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbxDisplayResult.Text.Contains("."))
                    tbxDisplayResult.Text += button.Text;
            }
            else {
                tbxDisplayResult.Text += button.Text;
            
            }
            
           
        }

        private void oper_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(tbxDisplayResult.Text);
            lbCurrentOp.Text = resultValue+" "+operationPerformed;
            isOperationPerformed = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbxDisplayResult.Text = "0";

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbxDisplayResult.Text = (resultValue + double.Parse(tbxDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbxDisplayResult.Text = (resultValue - double.Parse(tbxDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "X")
            {
                tbxDisplayResult.Text = (resultValue * double.Parse(tbxDisplayResult.Text)).ToString();

            }
            else
            {

                tbxDisplayResult.Text = (resultValue / double.Parse(tbxDisplayResult.Text)).ToString();
            }
        
        }

        private void btnDELL_Click(object sender, EventArgs e)
        {
            if (tbxDisplayResult.Text.Length > 0)
                tbxDisplayResult.Text = tbxDisplayResult.Text.Remove(tbxDisplayResult.Text.Length - 1, 1);
            if (tbxDisplayResult.Text == "")
                tbxDisplayResult.Text = "0";
                    }
    }
}
