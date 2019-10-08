using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriousCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //All number and operator buttons insert their symbol into the textbox when clicked
        private void OneBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 1;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 2;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 3;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 4;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 5;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 6;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 7;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 8;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 9;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + 0;
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + ".";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + "÷";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + "×";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = resultsBox.Text + "+";
        }

        private void ParenthesisBtn_Click(object sender, EventArgs e)
        {
            if ((resultsBox.Text.Contains('(') || resultsBox.Text.Contains(')')) == false)
            {
                resultsBox.Text = resultsBox.Text + "(";
            }
            else if (resultsBox.Text.LastIndexOf(')') > resultsBox.Text.LastIndexOf('('))
            {
                resultsBox.Text = resultsBox.Text + "(";
            }
            else
            {
                resultsBox.Text = resultsBox.Text + ")";
            }
        }

        //Backspace toolstrip button deletes last character. C button clears the textbox.
        private void BackspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultsBox.Text != string.Empty)
            {
                resultsBox.Text = resultsBox.Text.Remove(resultsBox.Text.Length - 1);
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = string.Empty;
        }

        //Convert symbols and evaluate the expression inside of the textbox
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder(resultsBox.Text);
            strBuilder.Replace('÷', '/');
            strBuilder.Replace('×', '*');

            DataTable dataTbl = new DataTable();
            var answer = dataTbl.Compute(strBuilder.ToString(),"");

            resultsBox.Text = answer.ToString();
        }
    }
}
