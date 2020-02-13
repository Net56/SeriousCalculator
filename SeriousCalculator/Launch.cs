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
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        //Go to selected application
        private void AppGoBtn_Click(object sender, EventArgs e)
        {
            if(appSelectBox.Text == "Calculator")
            {
                this.Hide();
                Calculator calc = new Calculator();
                calc.ShowDialog();
                this.Close();
            }
        }

        //Exit program
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
