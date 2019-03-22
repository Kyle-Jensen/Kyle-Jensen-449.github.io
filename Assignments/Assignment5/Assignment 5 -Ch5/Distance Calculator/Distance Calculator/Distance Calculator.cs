using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{   //The purpose of this form is to calculate distance of hours that is looped
    public partial class Distance_Calculator : Form
    {
        public Distance_Calculator()
        {
            InitializeComponent();
        }
        //Utilizing this event handler will calculate a looped distance of hours
        private void calcButton_Click(object sender, EventArgs e)
        {
            double mph; //declaring double for MPH
            double MAX_VALUE; //delcaring double for maximum number
            //Gets the MPH
            if (double.TryParse(vehicleSpeedTextBox.Text, out mph))
            {   //Gets the maxium number
                if (double.TryParse(hoursTraveledTextBox.Text, out MAX_VALUE))
                {   //Declaring a count that is double for the loop
                    double count = 1.0;
                    //Clears values that are in the listbox
                    calcListBox.Items.Clear();
                    //This loops calculates vehicle speed with each hour
                    while (count <= MAX_VALUE)
                    {   //adding the formula: count = mph * count
                        calcListBox.Items.Add("After Hours " + count + " the distance in miles is: " + mph * count);
                        count = count + 1; //Adds one to count
                    }
                }
            }
        }
        //this event handler purpose is to close the form
        private void exitButton_Click(object sender, EventArgs e)
        {   //closes the form
            this.Close();
        }
    }
}
