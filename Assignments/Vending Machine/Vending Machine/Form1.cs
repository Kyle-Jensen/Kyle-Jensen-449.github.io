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

        string[,] soda = new string[,] { {"Cola", "1.00", "20"}, { "Root Beer", "1.00", "20" }, { "Lemon Lime", "1.00", "20" }, { "Grape Soda", "1.50", "20" }, { "Cream Soda", "1.50", "20" } };

        double total_sales = 0.00;
        inputDrinks entry = new inputDrinks();
        int index;

        private void vendingMachine_Load(object sender, EventArgs e)
        {

        }
    }
}
