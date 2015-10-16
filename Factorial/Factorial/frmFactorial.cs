//AUTHOR: PIYUSH TRIPATHI
//COURSE: ISYS 601
//PROGRAM: CALCULATE FACTORIAL
//INITIALIZATION: lngResult and intNumber variable
//INPUT: user input number
//PROCESS: btnCalc_Click:run the loop and calculate factorial
//OUTPUT/DISPLAY: factorial value in textbox
//TERMINATION: NONE
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// calculate button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //get the numebr
            int intNumber = Convert.ToInt32(txtNumber.Text);
            long lngResult =1;
            //calculate the factorial
            while(intNumber>0){
                lngResult = lngResult * intNumber;
                intNumber--;
            }

            //display data
            txtFactorial.Text = lngResult.ToString("n0");
            //return the focus
            txtNumber.Focus();
            
        }
    }
}
