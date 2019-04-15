using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using produce_quantity.Objectssssss;
namespace produce_quantity
{
    public partial class Form4 : Form
    {
        GroceryItem _GroceryItem;
        public Form4(GroceryItem groceryItem)
        {
            _GroceryItem = groceryItem;
            InitializeComponent();

            

        }
    }
}
