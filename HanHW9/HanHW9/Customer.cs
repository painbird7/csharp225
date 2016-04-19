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

        // Constructor
        public Customer()
        {
            _customerNumber = 0;
        }

        // CustomerNumber property
        public int CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        // 
    }
}
