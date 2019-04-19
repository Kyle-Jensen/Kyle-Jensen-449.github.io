﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produce_quantity
{
    class itemInfo
    {
        //fields
        private string _Name;
        private string _Email;
        private string _Phone;
        //Constructor
        public itemInfo(string Name, string Email, string Phone)
        {
            _Name = Name;
            _Email = Email;
            _Phone = Phone;
        }
        //for name 
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        //for email
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        //for phone
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
    }
}
