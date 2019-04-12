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
            Category canned = new Category();
            canned._CategoryName = "Canned Goods";

            Form1 f = new Form1(canned);
            f.Show();
        }

        private void bakeryButton_Click(object sender, EventArgs e)
        {
            Category bakery = new Category();
            bakery._CategoryName = "Bakery Goods";

            Form1 f = new Form1(bakery);
            f.Show();
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            Category dairy = new Category();
            dairy._CategoryName = "Dairy Goods";

            Form1 f = new Form1(dairy);
            f.Show();
        }

        private void deliButton_Click(object sender, EventArgs e)
        {
            Category deli = new Category();
            deli._CategoryName = "Deli Goods";

            Form1 f = new Form1(deli);
            f.Show();
        }

        private void frozenButton_Click(object sender, EventArgs e)
        {
            Category frozen = new Category();
            frozen._CategoryName = "Frozen Goods";

            Form1 f = new Form1(frozen);
            f.Show();
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            Category meat = new Category();
            meat._CategoryName = "Meat Goods";

            Form1 f = new Form1(meat);
            f.Show();
        }

        private void packagedButton_Click(object sender, EventArgs e)
        {
            Category packaged = new Category();
            packaged._CategoryName = "Packaged Goods";

            Form1 f = new Form1(packaged);
            f.Show();
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            Category produce = new Category();
            produce._CategoryName = "Produce Goods";

            Form1 f = new Form1(produce);
            f.Show();
        }

        private void seafoodButton_Click(object sender, EventArgs e)
        {
            Category seafood = new Category();
            seafood._CategoryName = "Seafood";

            Form1 f = new Form1(seafood);
            f.Show();
        }
    }
}
