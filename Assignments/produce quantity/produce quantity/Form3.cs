using produce_quantity.Objectssssss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produce_quantity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cannedButton_Click(object sender, EventArgs e)
        {
            // create tuna item
            GroceryItem tuna = new GroceryItem("Tuna", "");
           
            // create category
            Category canned = new Category();
            // set category name
            canned._CategoryName = "Canned Goods";
            // add grocery items to category
            // more code here??

            Form1 f = new Form1(canned);
            f.Show();
        }

        private void bakeryButton_Click(object sender, EventArgs e)
        {
            GroceryItem bread = new GroceryItem("Bread", "");

            Category bakery = new Category();
            bakery._CategoryName = "Bakery Goods";

            Form1 f = new Form1(bakery);
            f.Show();
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            GroceryItem milk = new GroceryItem("Milk", "");

            Category dairy = new Category();
            dairy._CategoryName = "Dairy Goods";

            Form1 f = new Form1(dairy);
            f.Show();
        }

        private void deliButton_Click(object sender, EventArgs e)
        {
            GroceryItem sandwich = new GroceryItem("Sandwich", "");

            Category deli = new Category();
            deli._CategoryName = "Deli Goods";

            Form1 f = new Form1(deli);
            f.Show();
        }

        private void frozenButton_Click(object sender, EventArgs e)
        {
            GroceryItem icecream = new GroceryItem("Icecream", "");

            Category frozen = new Category();
            frozen._CategoryName = "Frozen Goods";

            Form1 f = new Form1(frozen);
            f.Show();
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            GroceryItem steak = new GroceryItem("Steak", "");

            Category meat = new Category();
            meat._CategoryName = "Meat Goods";

            Form1 f = new Form1(meat);
            f.Show();
        }

        private void packagedButton_Click(object sender, EventArgs e)
        {
            GroceryItem cereal = new GroceryItem("Cereal", "");

            Category packaged = new Category();
            packaged._CategoryName = "Packaged Goods";

            Form1 f = new Form1(packaged);
            f.Show();
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            GroceryItem apple = new GroceryItem("Appple", "");

            Category produce = new Category();
            produce._CategoryName = "Produce Goods";

            Form1 f = new Form1(produce);
            f.Show();
        }

        private void seafoodButton_Click(object sender, EventArgs e)
        {
            GroceryItem salmon = new GroceryItem("Salmon", "");

            Category seafood = new Category();
            seafood._CategoryName = "Seafood";

            Form1 f = new Form1(seafood);
            f.Show();
        }
    }
}
