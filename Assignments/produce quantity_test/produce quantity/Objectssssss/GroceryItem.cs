using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produce_quantity.Objectssssss
{
    public class GroceryItem
    {
        public string _Name;
        public List<string> _Stores = new List<string>();
        public List<string> _Nutrients = new List<string>();
        public List<string> _Facts = new List<string>();



        public GroceryItem() { }
        public GroceryItem(string name)
        {
            _Stores.Add("Walmart");
            _Stores.Add("Meijer");
            _Stores.Add("Target");

            _Nutrients.Add("5 Calories");
            _Nutrients.Add("5% Fat");
            _Nutrients.Add("27g Carbs");

            _Facts.Add("Very Yummy!");
            _Facts.Add("Sold since 1802!");

            _Name = name;

        }

       

    }

}
