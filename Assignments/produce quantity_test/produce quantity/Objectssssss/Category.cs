using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produce_quantity.Objectssssss
{
    public class Category
    {
        public string _CategoryName { get; set; }
        public List<GroceryItem> _Items { get; set; }

        public Category() { }

        public Category(string cName, List<GroceryItem> items)
        {
            _CategoryName = cName;
            _Items = items;
        }




    }

}
