using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{


    struct inputDrinks
    {
        public string name;
        public string price;
        public string drinkNumber;
    }


    public partial class vendingMachine : Form
    {
        public vendingMachine()
        {
            InitializeComponent();
        }

        private void vendingMachine_Load(object sender, EventArgs e)
        {

        }
    }
}
