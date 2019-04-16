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
namespace addressbook
{
    public partial class Form1 : Form
    {

        string nameOutput = "";
        List<string> vs = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText(@"../../data.txt");

            string lines;

            while (!inputFile.EndOfStream)
            {
                lines = inputFile.ReadLine();

            }
        }
    }
}
