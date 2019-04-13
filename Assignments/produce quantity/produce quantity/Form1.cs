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
    public partial class Form1 : Form
    {
        Category _Category;
        public Form1(Category category)
        {
            _Category = category;
            InitializeComponent();
            categoryName.Text = category._CategoryName;
            label1.Text = category._Items.ElementAtOrDefault(0)._Name;
            label2.Text = category._Items.ElementAtOrDefault(1)._Name;
            label3.Text = category._Items.ElementAtOrDefault(2)._Name;
            label4.Text = category._Items.ElementAtOrDefault(3)._Name;
            label5.Text = category._Items.ElementAtOrDefault(4)._Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("test.txt");

                outputFile.WriteLine("Apple: " + textBox1.Text);
                outputFile.WriteLine("Brocoli: " + textBox2.Text);
                outputFile.WriteLine("Potato: " + textBox3.Text);
                outputFile.WriteLine("Pear: " + textBox4.Text);
                outputFile.WriteLine("Corn: " +textBox5.Text);

                outputFile.Close();
               

                outputFile = File.CreateText("cannedTest.txt");
                outputFile.WriteLine("Tuna: " + textBox1.Text);
                outputFile.WriteLine("Baked Beans: " + textBox2.Text);
                outputFile.WriteLine("Spam: " + textBox3.Text);
                outputFile.WriteLine("Sliced Beans: " + textBox4.Text);
                outputFile.WriteLine("Canned Tomatoes: " + textBox5.Text);

                outputFile.Close();

                outputFile = File.CreateText("bakeryTest.txt");
                outputFile.WriteLine("Bread: " + textBox1.Text);
                outputFile.WriteLine("Muffin: " + textBox2.Text);
                outputFile.WriteLine("Pie: " + textBox3.Text);
                outputFile.WriteLine("Cookie: " + textBox4.Text);
                outputFile.WriteLine("Canned Tomatoes: " + textBox5.Text);

                outputFile.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
