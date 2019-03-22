using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Need this for StreamWriter

namespace Distance_Calculator
{   //The purpose of this form is to calculate distance of hours that is looped
    //creates a text file
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
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
                {   //declaring a StreamWriter variable
                    StreamWriter outputFile;
                    //Creating a txt file called distance calculator
                    outputFile = File.CreateText("Distance Calculator.txt"); 
                    //Declaring a count that is double for the loop
                    double count = 1.0;
                    //Clears values that are in the listbox
                    calcListBox.Items.Clear();
                    //This loops calculates vehicle speed with each hour
                    while (count <= MAX_VALUE)
                    {   //adding the formula: count = mph * count
                        //Outputting these values to the txt
                        outputFile.WriteLine("After Hours " + count + " the distance is " + mph * count);
                        count = count + 1; //Adds one to count
                    }
                    //Closes the file
                    outputFile.Close();
                    //message box prompts to tell user where txt is located
                    MessageBox.Show("This output is saved in: Distance Calculator_2 repo folder under Debug");
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
