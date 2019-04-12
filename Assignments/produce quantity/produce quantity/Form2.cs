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
                listBox1.Items.Add(inputFile.ReadLine());
                lines++;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            items();
        }
    }

       

       
    
}
