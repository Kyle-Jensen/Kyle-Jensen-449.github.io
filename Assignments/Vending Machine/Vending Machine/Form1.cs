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


    struct drinkInput
    {
        public string name;
        public string price;
        public int drinkNumber;
    }


    public partial class vendingMachine : Form
    {
        public vendingMachine()
        {
            InitializeComponent();
        }

        string[,] soda = new string[,] { {"Cola", "1.00", "20"}, {"Root Beer", "1.00", "20"}, {"Lemon Lime", "1.00", "20"}, {"Grape Soda", "1.50", "20"}, {"Cream Soda", "1.50", "20"} };

        double total = 0.00;
        drinkInput entry = new drinkInput();
        int index;

        private void vendingMachine_Load(object sender, EventArgs e)
        {

        }


        private void total_sales()
        {
            entry.name = soda[index, 0];
            entry.price = soda[index, 1];
            entry.drinkNumber = int.Parse(soda[index, 2]);

            if (entry.drinkNumber == 0)
            {
                MessageBox.Show(entry.name + " sold out.");
            }
            else
            {
                entry.drinkNumber--;
                soda[index, 2] = entry.drinkNumber.ToString();
                switch (index)
                {
                    case 0: cola.Text = entry.drinkNumber.ToString();
                        break;
                    case 1: rootbeer.Text = entry.drinkNumber.ToString();
                        break;
                    case 2: lemonlime.Text = entry.drinkNumber.ToString();
                        break;
                    case 3: grapesoda.Text = entry.drinkNumber.ToString();
                        break;
                    case 4: creamsoda.Text = entry.drinkNumber.ToString();
                        break;
                }

            }
        }
    }
}
