﻿using System;
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

            while (!inputFile.EndofStream)
            {
                inputFile.ReadLine();
                lines++;
            }
            gName = new string[lines];

            inputFile = File.OpenText("GirlNames.txt");

        }
    }
}
