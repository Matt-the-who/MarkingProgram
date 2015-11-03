/*
Created by Matthew Ho
Created on 11-03-15
Created for ICS3U
Assignment #4-04
This program converts a level mark to a percentage mark.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkingProgram
{
    public partial class frmMarkingProgram : Form
    {

        public int Conversion (string markAsLevel)
        {
            //this function converts level mark to integer mark
            int integerMark;

            if (markAsLevel == "4+")
            {
                integerMark = 95;
            }
            else if (markAsLevel == "4")
            {
                integerMark = 90;
            }
            else if (markAsLevel == "4-")
            {
                integerMark = 85;
            }
            else if (markAsLevel == "3+")
            {
                integerMark = 77;
            }
            else if (markAsLevel == "3")
            {
                integerMark = 75;
            }
            else if (markAsLevel == "3-")
            {
                integerMark = 72;
            }
            else if (markAsLevel == "2+")
            {
                integerMark = 67;
            }
            else if (markAsLevel == "2")
            {
                integerMark = 65;
            }
            else if (markAsLevel == "2-")
            {
                integerMark = 62;
            }
            else if (markAsLevel == "1+")
            {
                integerMark = 57;
            }
            else if (markAsLevel == "1")
            {
                integerMark = 55;
            }
            else if (markAsLevel == "1-")
            {
                integerMark = 52;
            }
            else if (markAsLevel == "R")
            {
                integerMark = 30;
            }
            else if (markAsLevel == "NE")
            {
                integerMark = 0;
            }
            else if (markAsLevel == "r")
            {
                integerMark = 30;
            }
            else if (markAsLevel == "ne")
            {
                integerMark = 0;
            }
            else integerMark = -1;

            return  integerMark;
        }

        public frmMarkingProgram()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string markAsLevel = this.txtMarkAsLevel.Text;
            int percentageMark;


            percentageMark = Conversion(markAsLevel);

            this.lblMarkAsInt.Text = "Your % mark is " + percentageMark;
        }
    }
}
