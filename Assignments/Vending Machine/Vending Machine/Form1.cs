using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this form allows a user to select their preference of soda. Selecting a soda decreases quantity and increased the total sale.
namespace Vending_Machine
{

    //a structure for drinkinput is delcared here
    struct drinkInput
    {   //declaring three strings for the structure
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

        double total_sales = 0.00;
        drinkInput entry = new drinkInput();
        int index;

        private void vendingMachine_Load(object sender, EventArgs e)
        {

        }


        private void sold_out()
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
                    case 0: colaLabel.Text = entry.drinkNumber.ToString();
                        break;
                    case 1: rootBeerLabel.Text = entry.drinkNumber.ToString();
                        break;
                    case 2: lemonLimeLabel.Text = entry.drinkNumber.ToString();
                        break;
                    case 3: grapeSodaLabel.Text = entry.drinkNumber.ToString();
                        break;
                    case 4: creamSodaLabel.Text = entry.drinkNumber.ToString();
                        break;
                }
                total_sales += double.Parse(entry.price);

                totalSalesLabel.Text = "$" + total_sales;



            }
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            index = 0;
            sold_out();
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            index = 1;
            sold_out();
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            index = 2;
            sold_out();
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            index = 3;
            sold_out();
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            index = 4;
            sold_out();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
