using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class Customer : Person
    {
        // Constructor
        public Customer(string name, string address, string phone, string customerNumber, bool mailing) 
            : base(name, address, phone)
        {
            CustomerNumber = customerNumber;
            Mailing = mailing;
        }

        // CustomerNumber property
        public string CustomerNumber
        {
            get; set;
        }

        // Mailing property
        public bool Mailing
        {
            get; set;
        }
    }
}
