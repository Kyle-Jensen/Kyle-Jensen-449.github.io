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
namespace produce_quantity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void items()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("test.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {   
                listBox6.Items.Add(inputFile.ReadLine());
                lines++;
            }
            inputFile.Close();
        }


        private void cannedItems()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("cannedTest.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {
                listBox1.Items.Add(inputFile.ReadLine());
                lines++;
            }
            inputFile.Close();
        }

        private void bakeryItems()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("bakeryTest.txt");

            int lines = 0;
            while (!inputFile.EndOfStream)
            {
                listBox2.Items.Add(inputFile.ReadLine());
                lines++;
            }
            inputFile.Close();
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            items();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            items();
            cannedItems();
            bakeryItems();
        }
    }

       

       
    
}
