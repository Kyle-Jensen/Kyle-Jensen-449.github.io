﻿using System;
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
    public partial class itemLocation : Form
    {
        public itemLocation()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet.Grocery_Items' table. You can move, or remove it, as needed.
            this.grocery_ItemsTableAdapter.Fill(this.groceryDBDataSet.Grocery_Items);

        }
        //goes back to groceryCategories form
        private void button1_Click(object sender, EventArgs e)
        {
            groceryCategories f = new groceryCategories();
            f.Show();
            this.Hide();
        }
    }
}
