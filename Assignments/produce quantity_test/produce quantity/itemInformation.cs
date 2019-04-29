using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//The purpose of this form is to show item information within the groceryCategoryItems forms
namespace produce_quantity
{
    public partial class itemInformation : Form
    {
        public itemInformation()
        {
            InitializeComponent();
        }
        //closes form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
