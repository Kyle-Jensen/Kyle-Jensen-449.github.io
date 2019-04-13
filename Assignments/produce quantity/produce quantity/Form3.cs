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
            GroceryItem tuna = new GroceryItem("Tuna");
            GroceryItem bakedbeans = new GroceryItem("Baked Beans");
            GroceryItem spam = new GroceryItem("Spam");
            GroceryItem slicedbeans = new GroceryItem("Sliced Beans");
            GroceryItem cannedtomatoes = new GroceryItem("Canned Tomatoes");


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
            GroceryItem bread = new GroceryItem("Bread");
            GroceryItem muffin = new GroceryItem("Muffins");
            GroceryItem pie = new GroceryItem("Pie");
            GroceryItem cookie = new GroceryItem("Cookie");
            GroceryItem buns = new GroceryItem("Buns");

            Category bakery = new Category();
            bakery._CategoryName = "Bakery Goods";

            Form1 f = new Form1(bakery);
            f.Show();
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            GroceryItem milk = new GroceryItem("Milk");
            GroceryItem butter = new GroceryItem("Butter");
            GroceryItem eggs = new GroceryItem("Eggs");
            GroceryItem cream = new GroceryItem("Cream");
            GroceryItem yogurt = new GroceryItem("Yogurt");

            Category dairy = new Category();
            dairy._CategoryName = "Dairy Goods";

            Form1 f = new Form1(dairy);
            f.Show();
        }

        private void deliButton_Click(object sender, EventArgs e)
        {
            GroceryItem sandwich = new GroceryItem("Sandwich");
            GroceryItem salad = new GroceryItem("Salad");
            GroceryItem wrap = new GroceryItem("Wrap");
            GroceryItem slicedmeat = new GroceryItem("Sliced Meat");
            GroceryItem slicedcheese = new GroceryItem("Slice Cheese");

            Category deli = new Category();
            deli._CategoryName = "Deli Goods";

            Form1 f = new Form1(deli);
            f.Show();
        }

        private void frozenButton_Click(object sender, EventArgs e)
        {
            GroceryItem icecream = new GroceryItem("Icecream");
            GroceryItem frozenvegetables = new GroceryItem("Frozen Vegetables");
            GroceryItem frozenfruits = new GroceryItem("Frozen Fruits");
            GroceryItem frozenpizza = new GroceryItem("Frozen Pizza");
            GroceryItem frozenpretzel = new GroceryItem("Frozen Pretzel");

            Category frozen = new Category();
            frozen._CategoryName = "Frozen Goods";

            Form1 f = new Form1(frozen);
            f.Show();
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            GroceryItem steak = new GroceryItem("Steak");
            GroceryItem chicken = new GroceryItem("Chicken");
            GroceryItem pork = new GroceryItem("Pork");
            GroceryItem lamb = new GroceryItem("Lamb");
            GroceryItem veal = new GroceryItem("Veal");

            Category meat = new Category();
            meat._CategoryName = "Meat Goods";

            Form1 f = new Form1(meat);
            f.Show();
        }

        private void packagedButton_Click(object sender, EventArgs e)
        {
            GroceryItem cereal = new GroceryItem("Cereal");
            GroceryItem chips = new GroceryItem("Chips");
            GroceryItem crackers = new GroceryItem("Crackers");
            GroceryItem popcorn = new GroceryItem("Popcorn");
            GroceryItem fruitsnacks = new GroceryItem("Fruit Snacks");

            Category packaged = new Category();
            packaged._CategoryName = "Packaged Goods";

            Form1 f = new Form1(packaged);
            f.Show();
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            GroceryItem apple = new GroceryItem("Appple");
            GroceryItem brocoli = new GroceryItem("Brocoli");
            GroceryItem potato = new GroceryItem("Potato");
            GroceryItem pear = new GroceryItem("Pear");
            GroceryItem corn = new GroceryItem("Corn");

            Category produce = new Category();
            produce._CategoryName = "Produce Goods";

            Form1 f = new Form1(produce);
            f.Show();
        }

        private void seafoodButton_Click(object sender, EventArgs e)
        {
            GroceryItem salmon = new GroceryItem("Salmon");
            GroceryItem trout = new GroceryItem("Trout");
            GroceryItem shrimp = new GroceryItem("Shrimp");
            GroceryItem crab = new GroceryItem("Crab");
            GroceryItem lobster = new GroceryItem("Lobster");

            Category seafood = new Category();
            seafood._CategoryName = "Seafood";

            Form1 f = new Form1(seafood);
            f.Show();
        }
    }
}
