using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This form converts celsuis to fahrenheit
namespace Celsius_to_Fahrenheit_Table1
{
    public partial class CtF : Form
    {
        public CtF()
        {
            InitializeComponent();
        }
        //The evant handler is the form itself. It calculates and converts cesius to farenheit that utilizes a loop
        private void Form1_Load(object sender, EventArgs e)
        {   //declaring double for fahrenheit
            double fahrenheit;
            double celsius; //decraling double for celsius
            celsius = 0; //setting celsius to 0
            //Displays celius and fahrenheit on form
            tempOutPutListBox.Items.Add("Celsisus" + "     " + "Fahrenheit");
            //This loops displays celsius 20 times
            while (celsius <= 20)
            {   //converter formula
                fahrenheit = (9.0 / 5.0 * celsius) + 32; 
                tempOutPutListBox.Items.Add(celsius + "                " + fahrenheit); //adds values to listbox with specified spacing
                celsius = celsius + 1; //adds one to count
            }
        }
    }
}
