using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopListBoxMod___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 04/11/2021
    //Goal: Display years in listbox indicating election or census if desired
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            //VARIABLES
            //Input variables
            bool tryParseResult;
            int startYear = 0;
            int endYear = 0;
            //Year string variable
            string myString = "";
            //Loop variable
            int loopYear = 0;
            //Clear listbox on new button push
            yrLst.Items.Clear();

            //INPUT
            //Get start year as input from user
            tryParseResult = int.TryParse(startYrInput.Text, out startYear);
            //Show error if start year nonnumeric or before 1776
            if (tryParseResult == false || startYear < 1776)
            { MessageBox.Show("Error: Please enter valid start year after 1776.");
                return;
            }
            //Get end year as input from user
            tryParseResult = int.TryParse(endYrInpt.Text, out endYear);
            //Show errer is end year nonnumeric or smaller than startYear
            if (tryParseResult == false || startYear > endYear)
            { MessageBox.Show("Error: Please enter a valid end year that comes after the start year.");
                return;
            }
            //PROCESSING AND OUTPUT
            loopYear = startYear;
            while (loopYear <= endYear)
            {
            //Create year string
            myString = "Year: " + loopYear.ToString();
            //Determine if election year
            if (eleCkBx.Checked == true && loopYear % 4 == 0)
                { myString = myString + ", is an Election Year"; }
            //Determine if census year
            if (censusCkBx.Checked == true && loopYear % 10 == 0)
                { myString = myString + ", is a Census Year"; }
            //Display string in listbox
                yrLst.Items.Add(myString);
            //Add 1 to year to continue loop
                loopYear = loopYear + 1;
            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear year input textboxes
            startYrInput.Text = "";
            endYrInpt.Text = "";
            //Clear checkboxes if checked
            eleCkBx.Checked = false;
            censusCkBx.Checked = false;
            //Clear listbox
            yrLst.Items.Clear();
        }
    }
}
