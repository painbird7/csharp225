using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class Person
    {
        // Fields
        private string _name, _address, _phone;

        // Constructor
        public Person()
        {
            _name = "";
            _address = "";
            _phone = "";
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
