using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class Customer : Person
    {
        // Fields
        private int _customerNumber;
        private string _email;
        private bool _mailing;

        // Constructor
        public Customer(string name, string address, string phone, int customerNumber, bool mailing) 
            : base(name, address, phone)
        {
            _customerNumber = customerNumber;
            _mailing = mailing;
        }

        // CustomerNumber property
        public int CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        // Mailing property
        public bool Mailing
        {
            get { return _mailing; }
            set { _mailing = value; }
        }
    }
}
