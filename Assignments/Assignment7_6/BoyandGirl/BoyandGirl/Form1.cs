using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BoyandGirl //this form allows a user to pic a name, then it outputs stating if the name is popular or not popular
{
    public partial class boyAndGirlForm : Form
    {
        public boyAndGirlForm()
        {
            InitializeComponent();
        }
        //creating an array for two variables
        string[] gName;
        string[] bName;
        //the form event handler. declaring two variables
        private void boyAndGirlForm_Load(object sender, EventArgs e)
        {   
            rGName();
            rBName();
        }
        //this method reades and grabs data from the girlsname.txt file
        private void rGName()
        {   //declaring streamreader variable
            StreamReader inputFile;
            //opens the file
            inputFile = File.OpenText(@"../../../../../txt/GirlNames.txt");
            //variable to hold number of items stores in the array
            int lines = 0;
            //end of file is reached
            while (!inputFile.EndOfStream)
            {   //adding item
                inputFile.ReadLine();
                lines++;
            }
            gName = new string[lines];
            //opens file
            inputFile = File.OpenText(@"../../../../../txt/GirlNames.txt");
            //variable to hold number of items stores in the array
            int index = 0;
            while (index < gName.Length && !inputFile.EndOfStream)
            {   //assigning text for the array
                gName[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close(); //closes file


        }
        //this method reades and grabes data from boynames.txt file
        private void rBName()
        {   //declaring streamreader variable
            StreamReader inputFile;
            //opens file
            inputFile = File.OpenText(@"../../../../../txt/BoyNames.txt");
            //varialbe to hold number of items in the array
            int lines = 0;
            //end of file is reached
            while (!inputFile.EndOfStream)
            {   //adding item
                inputFile.ReadLine();
                lines++;
                
            }

            bName = new string[lines];
            //opens file
            inputFile = File.OpenText(@"../../../../../txt/BoyNames.txt");
            //variable to hold number of items stores in the array
            int index = 0;
            while (index < bName.Length && !inputFile.EndOfStream)
            {   //assigning text for the array
                bName[index] = inputFile.ReadLine();
                index++;
            }

            inputFile.Close(); //closes file
        }
        //purpose of this method is to display the data from both of the text files and show if the names are popular or not popular
        private void goButton_Click(object sender, EventArgs e)
        {   //to clear
            boyGirlLabel.Text = "";
            //is popular boy name is false, then not a popular name
            if (boyTextbox.Text != "")
            {
                Boolean pBName = false;
                for (int index = 0; index < bName.Length; index++)
                {
                    if (bName[index] == boyTextbox.Text)
                    {
                        pBName = true;
                        
                    }
                }
                //if popular boy name is true, then popular 
                if (pBName == true)
                {
                    boyGirlLabel.Text += boyTextbox.Text + " is a popular boy name.\n";
                }
                else
                {
                    boyGirlLabel.Text += boyTextbox.Text + " is not a popular boy name.\n";
                }
            }
            //if popular girl name is false, then not a popular name
            if (girlTextbox.Text != "")
            {  
                Boolean pGName = false;
                for (int index = 0; index < gName.Length; index++)
                {
                    if (gName[index] == girlTextbox.Text)
                    {
                        pGName = true;
                        
                    }
                }//if popular girl name is true, then popular name
                if (pGName == true)
                {
                    boyGirlLabel.Text += girlTextbox.Text + " is a popular girl name.\n";
                }
                else
                {
                    boyGirlLabel.Text += girlTextbox.Text + " is not a popular girl name.\n";
                }
            }
        }
        //clear button method
        private void clearButton_Click(object sender, EventArgs e)
        {
            boyGirlLabel.Text = "";
        }
    }
}
