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
namespace bBall //This form displays a baseball teams number of wins through years 1903 and 2012
{   
    public partial class worldSeriesChampions : Form
    {
        public worldSeriesChampions()
        {
            InitializeComponent();
        }
        //creating an array for two variables
        string[] baseballTeams;
        string[] winnerTeams;
        //The form event handler. declaring two variables
        private void worldSeriesChampions_Load(object sender, EventArgs e)
        {
            rBaseballTeams();
            rWinnerTeams();
            
        }
        //this method rBaseballTeams reads and grabs data from the Teams.txt file to show on the teamsListBox 
        private void rBaseballTeams()
        {   //decarling streamreader variable
            StreamReader inputFile;
            //opens teams.txt file
            inputFile = File.OpenText("Teams.txt");
            //variable to hold number of items stores in the array
            int lines = 0;
            //end of file is reached
            while (!inputFile.EndOfStream)
            {   //adding item
                teamsListBox.Items.Add(inputFile.ReadLine());
                lines++;
            }

            baseballTeams = new string[lines];
            //opens teams.txt file
            inputFile = File.OpenText("Teams.txt");
            //variable to hold number of items stores in the array
            int index = 0;
            while (index < baseballTeams.Length && !inputFile.EndOfStream) //reads teams.txt into the array
            {   
                baseballTeams[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();  //closes file
        }

        private void rWinnerTeams()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("WorldSeriesWinners.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {
                inputFile.ReadLine();
                lines++;
            }

            winnerTeams = new string[lines];

            inputFile = File.OpenText("WorldSeriesWinners.txt");

            int index = 0;
            while (index < winnerTeams.Length && !inputFile.EndOfStream)
            {
                winnerTeams[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asdf = teamsListBox.SelectedItem.ToString();
            int wins = 0;
            for (int i = 0; i < winnerTeams.Length; i++)
            {
                if (asdf == winnerTeams[i])
                {
                    wins++;
                }
            }
            winnersLabel.Text = asdf + " won " + wins + " times from 1903 -2012.";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            winnersLabel.Text = "";
        }
    }
}
