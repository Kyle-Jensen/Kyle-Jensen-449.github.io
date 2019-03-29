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
namespace BoyandGirl
{
    public partial class boyAndGirlForm : Form
    {
        public boyAndGirlForm()
        {
            InitializeComponent();
        }

        private void boyAndGirlForm_Load(object sender, EventArgs e)
        {
            gName();
            bName();
        }

        private void rGName()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("GirlNames.txt");

            int lines = 0;

            while (!inputeFile.EndofStream)
        }
    }
}
