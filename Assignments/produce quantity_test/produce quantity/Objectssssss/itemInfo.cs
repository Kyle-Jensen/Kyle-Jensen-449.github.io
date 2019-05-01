using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produce_quantity.Objectssssss
{
    class itemInfo
    {
        //fields
        private string _Item;
        private string _Nutrient;
        private string _Store;
        private string _Store1;
        private string _Store2;
        private string _Fact;

        //Constructor
        public itemInfo(string Item, string Nutrient, string Store, string Store1, string Store2, string Fact)
        {
            _Item = Item;
            _Nutrient = Nutrient;
            _Store = Store;
            _Store1 = Store1;
            _Store2 = Store2;
            _Fact = Fact;
        }
        //for item
        public string Item
        {
            get
            {
                return _Item;
            }
            set
            {
                _Item = value;
            }
        }
        //for nurtient
        public string Nutrient
        {
            get
            {
                return _Nutrient;
            }
            set
            {
                _Nutrient = value;
            }
        }
        //for store
        public string Store
        {
            get
            {
                return _Store;
            }
            set
            {
                _Store = value;
            }
        }
        //for store1
        public string Store1
        {
            get
            {
                return _Store1;
            }
            set
            {
                _Store1 = value;
            }
        }
        //for store2
        public string Store2
        {
            get
            {
                return _Store2;
            }
            set
            {
                _Store2 = value;
            }
        }
        //for fact
        public string Fact
        {
            get
            {
                return _Fact;
            }
            set
            {
                _Fact = value;
            }
        }
    }
}

