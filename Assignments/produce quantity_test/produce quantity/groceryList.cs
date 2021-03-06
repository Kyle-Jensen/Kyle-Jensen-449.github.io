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
using produce_quantity.Objectssssss;

namespace produce_quantity
{
    public partial class groceryList : Form
    {
        public groceryList()
        {
            InitializeComponent();
        }
        //referecings GroceryItem class
        List<GroceryItem> listOfGroceries = new List<GroceryItem>();

        //opens and reads text file, produce.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void produceItems()
        {
            try
            {

                StreamReader inputFile;
                inputFile = File.OpenText("Produce.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox6.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //opens and reads text file, canned.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void cannedItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Canned.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox1.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, bakery.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void bakeryItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Bakery.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox2.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, dairy.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void dairyItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Dairy.txt");
               
                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox9.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, deli.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void deliItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Deli.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox5.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, frozen.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void frozenItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Frozen.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox4.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, meat.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void meatItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Meat.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox8.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, packaged.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void packagedItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Packaged.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox3.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
                    lines++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens and reads text file, seafood.txt
        //outputs the text into listbox
        //listbox adds selected groceryitem that the user selected and quantity
        private void seafoodItems()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Seafood.txt");

                int lines = 0;
                while (!inputFile.EndOfStream)
                {
                    string item = inputFile.ReadLine();
                    listBox7.Items.Add(item);
                    listOfGroceries.Add(new GroceryItem(item));
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
        //loads the items
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
            seafoodItems();
        }
        //back to previous form
        private void backButton_Click(object sender, EventArgs e)
        {
            groceryCategories f = new groceryCategories();
            f.Show();
            this.Hide();
        }
        //clears txt file and listboxes
        private void clearTextLabelButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Produce.txt", String.Empty);
            File.WriteAllText("Canned.txt", String.Empty);
            File.WriteAllText("Bakery.txt", String.Empty);
            File.WriteAllText("Dairy.txt", String.Empty);
            File.WriteAllText("Deli.txt", String.Empty);
            File.WriteAllText("Frozen.txt", String.Empty);
            File.WriteAllText("Meat.txt", String.Empty);
            File.WriteAllText("Packaged.txt", String.Empty);
            File.WriteAllText("Seafood.txt", String.Empty);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listOfGroceries.Clear();
        }
        //creates a text file called print
        //text file contains items the user selected
        //print dialog prompts up
        private void printButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("print.txt");


            foreach (GroceryItem GroceryItem in listOfGroceries) {
                outputFile.WriteLine(GroceryItem._Name);
            }
            outputFile.Close();


            PrintDialog print = new PrintDialog();
            print.ShowDialog();

        }
    }

       

       
    
}
