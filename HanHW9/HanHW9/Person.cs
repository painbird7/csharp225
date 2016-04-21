using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    public class Person
    {
        // Fields
        private string _name;
        private string _address;
        private string _phone;

        // Constructor
        public Person(string name, string address, string phone)
        {
            _name = name;
            _address = address;
            _phone = phone;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       
        // Address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Phone property
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
