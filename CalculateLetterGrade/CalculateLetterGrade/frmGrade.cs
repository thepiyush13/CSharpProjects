
//AUTHOR:			Piyush Tripathi
//COURSE:			ISYS 601 601: FUNDAMENTALS OF BUS PROG
//PROGRAM:			frmGrade
//PURPOSE:			 Calculate Letter Grade 
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

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// click event for calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             decimal decNumberGrade = Convert.ToDecimal(txtNumberGrade.Text);
             string strLetterGrade = "";
             if (decNumberGrade >= 88)
             {
                 strLetterGrade = "A";
             }
             else if (decNumberGrade >= 80 && decNumberGrade <= 87)
             {
                 strLetterGrade = "B";
             }
             else if (decNumberGrade >= 68 && decNumberGrade <= 79)
             {
                 strLetterGrade = "C";
             }
             else if (decNumberGrade >= 60 && decNumberGrade <= 67)
             {
                 strLetterGrade = "D";
             }
             else
             {
                 strLetterGrade = "F";
             }
             txtLetterGrade.Text = strLetterGrade;
             txtNumberGrade.Focus();
             txtNumberGrade.SelectAll();
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
    }
}
