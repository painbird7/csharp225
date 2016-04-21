using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    public class Person
    {
        // Constructor
        public Person(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        // Name property
        public string Name
        {
            get; set;
        }
       
        // Address property
        public string Address
        {
            get; set;
        }

        // Phone property
        public string Phone
        {
            get; set;
        }
    }
}
