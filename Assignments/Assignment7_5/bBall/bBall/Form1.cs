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
namespace bBall
{
    public partial class worldSeriesChampions : Form
    {
        public worldSeriesChampions()
        {
            InitializeComponent();
        }

        string[] baseballTeams;
        string[] winnerTeams;

        private void worldSeriesChampions_Load(object sender, EventArgs e)
        {
            rBaseballTeams();
            
        }

        private void rBaseballTeams()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("Teams.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {
                teamsListBox.Items.Add(inputFile.ReadLine());
                lines++;
            }
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
    }
}
