using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    class PersonEntry
    {
        private string _name;
        private string _email;
        private string _phoneNum;

        public PersonEntry(string name, string email, string phoneNum)
        {
            _name = name;
            _email = email;
            _phoneNum = phoneNum;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string PhoneNum
        {
            get
            {
                return _phoneNum;
            }
            set
            {
                _phoneNum = value;
            }
        }
    }
}
