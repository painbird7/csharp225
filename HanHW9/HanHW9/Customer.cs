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
        private string _customerNumber;
        private bool _mailing;

        // Constructor
        public Customer()
        {
            _customerNumber = "";
        }

        // CustomerNumber property
        public string CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        // 
        public bool Mailing
        {
            get { return _mailing; }
            set { _mailing = value; }
        }
    }
}
