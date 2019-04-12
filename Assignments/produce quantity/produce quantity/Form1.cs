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
namespace produce_quantity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("test.txt");

                outputFile.WriteLine("Potato(s): " + textBox1.Text);
                outputFile.WriteLine("Corn: " + textBox2.Text);
                outputFile.WriteLine("Brocoli: " + textBox3.Text);
                outputFile.WriteLine("Tomato(s): " + textBox4.Text);
                outputFile.WriteLine("Carrot(s): " +textBox5.Text);
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
        }
    }
}
