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

        

        private void produceItems()
        {
            try
            {

                StreamReader inputFile;
                inputFile = File.OpenText("Produce.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox6.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cannedItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Canned.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox1.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bakeryItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Bakery.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox2.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dairyItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Dairy.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox9.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deliItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Deli.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox3.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frozenItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Frozen.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox4.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void meatItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Meat.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox8.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void packagedItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Packaged.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox5.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seafoodItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Seafood.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    listBox7.Items.Add(inputFile.ReadLine());
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            produceItems();
            cannedItems();
            bakeryItems();
            dairyItems();
            deliItems();
            frozenItems();
            meatItems();
            packagedItems();
            produceItems();
            seafoodItems();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }

       

       
    
}
