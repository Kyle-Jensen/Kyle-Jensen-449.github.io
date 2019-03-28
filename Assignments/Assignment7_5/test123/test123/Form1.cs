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
namespace test123
{
    public partial class worldSeriesChampions : Form
    {
        public worldSeriesChampions()
        {
            InitializeComponent();
        }
        sadasdasdasd
        string[] baseballTeams;
        string[] winnerTeams;



        private void teamsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = teamslistBox.SelectedItem.ToString();
            int wins = 0;
            for (int i = 0; i < winnerTeams.Length; i++)
            {
                if (str == winnerTeams[i])
                {
                    wins++;
                }
            }
            winnersLabel.Text = str + " won " + wins + " times from 1903 - 2012.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rBaseballTeams();
            rWinnerTeams();
        }

        private void rBaseballTeams()
        {
            
            
                StreamReader inputFile;
                inputFile = File.OpenText("Teams.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    teamslistBox.Items.Add(inputFile.ReadLine());
                    lines++;
                }

                baseballTeams = new string[lines];

                inputFile = File.OpenText("Teams.txt");
                int index = 0;
                while (index < baseballTeams.Length && !inputFile.EndOfStream)
                {
                    baseballTeams[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close();
            
           
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            winnersLabel.Text = "";
        }
    }
}
