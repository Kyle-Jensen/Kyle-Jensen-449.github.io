using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    class addData
    {
        private string _Name;
        private string _Email;
        private string _Phone;


        public addData(string Name, string Email, string Phone)
        {
            _Name = Name;
            _Email = Email;
            _Phone = Phone;
        }

        public string forName
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

        public string forEmail
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

        public string forPhone
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
