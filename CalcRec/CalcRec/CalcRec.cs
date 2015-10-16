
//AUTHOR:			Piyush Tripathi
//COURSE:			ISYS 601 601: FUNDAMENTALS OF BUS PROG
//PROGRAM:			frmCalc
//PURPOSE:			 Calculate Recangle area and perimeter
//INPUT:			Length and Width
//OUTPUT/DISPLAY:	Letter grade
//HONOR CODE:		“On my honor, as an Aggie, I have neither given nor received unauthorized aid on this academic work.”


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRec
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// click event for exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// click event for calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //get length and width
            decimal decLength = Convert.ToDecimal(txtLength.Text);
            decimal decWidth = Convert.ToDecimal(txtWidth.Text);

            //input validation
            
            //calculate area
            decimal area = decLength * decWidth;
            //calculate perimeter
            decimal peri = 2*(decLength+decWidth);

            //update values
            txtArea.Text = Convert.ToString(area);
            txtPeri.Text = Convert.ToString(peri);

            //cleanup
            txtLength.Focus();



        }
    }
}
