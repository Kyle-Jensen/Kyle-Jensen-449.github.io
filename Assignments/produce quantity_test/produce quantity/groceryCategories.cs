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
    public partial class groceryCategories : Form
    {
        public groceryCategories()
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

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(tuna);
            itemList.Add(bakedbeans);
            itemList.Add(spam);
            itemList.Add(slicedbeans);
            itemList.Add(cannedtomatoes);

            // create category
            Category canned = new Category("Canned", itemList);
            // set category name
            
            // add grocery items to category
            // more code here??

            groceryCategoryItems f = new groceryCategoryItems(canned);
            f.Show();
            this.Hide();
        }

        private void bakeryButton_Click(object sender, EventArgs e)
        {
            GroceryItem bread = new GroceryItem("Bread");
            GroceryItem muffin = new GroceryItem("Muffin");
            GroceryItem pie = new GroceryItem("Pie");
            GroceryItem cookie = new GroceryItem("Cookie");
            GroceryItem buns = new GroceryItem("Buns");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(bread);
            itemList.Add(muffin);
            itemList.Add(pie);
            itemList.Add(cookie);
            itemList.Add(buns);


            Category bakery = new Category("Bakery", itemList);
            
            groceryCategoryItems f = new groceryCategoryItems(bakery);
            f.Show();
            this.Hide();
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            GroceryItem milk = new GroceryItem("Milk");
            GroceryItem butter = new GroceryItem("Butter");
            GroceryItem eggs = new GroceryItem("Eggs");
            GroceryItem cream = new GroceryItem("Cream");
            GroceryItem yogurt = new GroceryItem("Yogurt");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(milk);
            itemList.Add(butter);
            itemList.Add(eggs);
            itemList.Add(cream);
            itemList.Add(yogurt);


            Category dairy = new Category("Dairy", itemList);
            

            groceryCategoryItems f = new groceryCategoryItems(dairy);
            f.Show();
            this.Hide();
        }

        private void deliButton_Click(object sender, EventArgs e)
        {
            GroceryItem sandwich = new GroceryItem("Sandwich");
            GroceryItem salad = new GroceryItem("Salad");
            GroceryItem wrap = new GroceryItem("Wrap");
            GroceryItem slicedmeat = new GroceryItem("Sliced Meat");
            GroceryItem slicedcheese = new GroceryItem("Sliced Cheese");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(sandwich);
            itemList.Add(salad);
            itemList.Add(wrap);
            itemList.Add(slicedmeat);
            itemList.Add(slicedcheese);


            Category deli = new Category("Deli", itemList);
            

            groceryCategoryItems f = new groceryCategoryItems(deli);
            f.Show();
            this.Hide();
        }

        private void frozenButton_Click(object sender, EventArgs e)
        {
            GroceryItem icecream = new GroceryItem("Icecream");
            GroceryItem frozenvegetables = new GroceryItem("Frozen Vegetables");
            GroceryItem frozenfruits = new GroceryItem("Frozen Fruits");
            GroceryItem frozenpizza = new GroceryItem("Frozen Pizza");
            GroceryItem frozenpretzel = new GroceryItem("Frozen Pretzel");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(icecream);
            itemList.Add(frozenvegetables);
            itemList.Add(frozenfruits);
            itemList.Add(frozenpizza);
            itemList.Add(frozenpretzel);

            Category frozen = new Category("Frozen", itemList);
           

            groceryCategoryItems f = new groceryCategoryItems(frozen);
            f.Show();
            this.Hide();
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            GroceryItem steak = new GroceryItem("Steak");
            GroceryItem chicken = new GroceryItem("Chicken");
            GroceryItem pork = new GroceryItem("Pork");
            GroceryItem lamb = new GroceryItem("Lamb");
            GroceryItem veal = new GroceryItem("Veal");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(steak);
            itemList.Add(chicken);
            itemList.Add(pork);
            itemList.Add(lamb);
            itemList.Add(veal);


            Category meat = new Category("Meat", itemList);
            

            groceryCategoryItems f = new groceryCategoryItems(meat);
            f.Show();
            this.Hide();
        }

        private void packagedButton_Click(object sender, EventArgs e)
        {
            GroceryItem cereal = new GroceryItem("Cereal");
            GroceryItem chips = new GroceryItem("Chips");
            GroceryItem crackers = new GroceryItem("Crackers");
            GroceryItem popcorn = new GroceryItem("Popcorn");
            GroceryItem fruitsnacks = new GroceryItem("Fruit Snacks");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(cereal);
            itemList.Add(chips);
            itemList.Add(crackers);
            itemList.Add(popcorn);
            itemList.Add(fruitsnacks);


            Category packaged = new Category("Packaged", itemList);
            

            groceryCategoryItems f = new groceryCategoryItems(packaged);
            f.Show();
            this.Hide();
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            GroceryItem apple = new GroceryItem("Apple");
            GroceryItem brocoli = new GroceryItem("Brocoli");
            GroceryItem potato = new GroceryItem("Potato");
            GroceryItem pear = new GroceryItem("Pear");
            GroceryItem corn = new GroceryItem("Corn");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(apple);
            itemList.Add(brocoli);
            itemList.Add(potato);
            itemList.Add(pear);
            itemList.Add(corn);


            Category produce = new Category("Produce", itemList);
      

            groceryCategoryItems f = new groceryCategoryItems(produce);
            f.Show();
            this.Hide();
        }

        private void seafoodButton_Click(object sender, EventArgs e)
        {
            GroceryItem salmon = new GroceryItem("Salmon");
            GroceryItem trout = new GroceryItem("Trout");
            GroceryItem shrimp = new GroceryItem("Shrimp");
            GroceryItem crab = new GroceryItem("Crab");
            GroceryItem lobster = new GroceryItem("Lobster");

            List<GroceryItem> itemList = new List<GroceryItem>();
            itemList.Add(salmon);
            itemList.Add(trout);
            itemList.Add(shrimp);
            itemList.Add(crab);
            itemList.Add(lobster);


            Category seafood = new Category("Seafood", itemList);
           

            groceryCategoryItems f = new groceryCategoryItems(seafood);
            f.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            groceryList f = new groceryList();
            f.Show();
            this.Hide();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            itemLocation f = new itemLocation();
            f.Show();
            
        }
    }
}
