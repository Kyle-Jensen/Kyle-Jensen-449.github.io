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
namespace BoyandGirl
{
    public partial class boyAndGirlForm : Form
    {
        public boyAndGirlForm()
        {
            InitializeComponent();
        }

        string[] gName;
        string[] bName;

        private void boyAndGirlForm_Load(object sender, EventArgs e)
        {
            rGName();
            rBName();
        }

        private void rGName()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("GirlNames.txt");

            int lines = 0;

            while (!inputFile.EndOfStream)
            {
                inputFile.ReadLine();
                lines++;
            }
            gName = new string[lines];

            inputFile = File.OpenText("GirlNames.txt");
            int index = 0;
            while (index < gName.Length && !inputFile.EndOfStream)
            {
                gName[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();


        }
        private void rBName()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("BoyNames.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {
                inputFile.ReadLine();
                lines++;
                
            }

            bName = new string[lines];

            inputFile = File.OpenText("BoyNames.txt");
            int index = 0;
            while (index < bName.Length && !inputFile.EndOfStream)
            {
                bName[index] = inputFile.ReadLine();
                index++;
            }

            inputFile.Close();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            boyGirlLabel.Text = "";

            if (boyTextbox.Text != "")
            {
                Boolean pBName = false;
                for (int index = 0; index < bName.Length; index++)
                {
                    if (bName[index] == boyTextbox.Text)
                    {
                        pBName = true;
                        break;
                    }
                }

                if (pBName == true)
                {
                    boyGirlLabel.Text += boyTextbox.Text + " is a popular boy name.\n";
                }
                else
                {
                    boyTextbox.Text += boyTextbox.Text + " is not a popular boy name.\n";
                }
            }

            if (girlTextbox.Text != "")
            {
                Boolean pGName = false;
                for (int index = 0; index < gName.Length; index++)
                {
                    if (gName[index] == girlTextbox.Text)
                    {
                        pGName = true;
                        break;
                    }
                }
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            boyGirlLabel.Text = "";
        }
    }
}
