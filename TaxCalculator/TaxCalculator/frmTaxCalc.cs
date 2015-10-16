//AUTHOR: PIYUSH TRIPATHI
//COURSE: ISYS 601
//PROGRAM: CALCULATE INCOME TAX
//INITIALIZATION: DECINCOME AND DECTAXOWNED
//INPUT: user input INCOME VALUE
//PROCESS: btnCalc_Click:run the CONDITIONS and calculate OWNNED TAX AMOUNT
//OUTPUT/DISPLAY: TAX AMOUNT IN textbox
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

namespace TaxCalculator
{
    public partial class frmTaxCalc : Form
    {
        public frmTaxCalc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event for exit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// click event for calculate button click      
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //get user input
            Decimal decIncome = Convert.ToDecimal(txtIncome.Text);
            decimal decTaxOwned=0;
            //calculate tax
            if(decIncome>0 && decIncome<=8700){
                decTaxOwned = 0 +  ( ( (decIncome-0)*10)/100);
            }
            else if(decIncome>8700 && decIncome<=35350){
                decTaxOwned = 870 +  ( ( (decIncome-8700)*15)/100);
            }
            else if (decIncome > 35350 && decIncome <= 85650)
            {
                decTaxOwned = 4867 + (((decIncome - 35350) * 25) / 100);
            }
            else if (decIncome > 85650 && decIncome <= 178650)
            {
                decTaxOwned = 17442 + (((decIncome - 85650) * 28) / 100);
            }
            else if (decIncome > 178650 && decIncome <= 388350)
            {
                decTaxOwned = 43482 + (((decIncome - 178650) * 33) / 100);
            }
            else
            {
                if (decIncome > 388350)
                {
                    decTaxOwned = 112683 + (((decIncome - 388350) * 35) / 100);
                }
            }
            //display the data
            int intResult = (int)(decTaxOwned);
            txtOwned.Text = intResult.ToString("c0");
            txtIncome.Focus();

        }
    }
}
