using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class PreferredCustomer : Customer
    {
        // Fields
        private decimal _purchaseAmount;
        private decimal _discountLevel;

        // Constructor
        public PreferredCustomer(string name, string address, string phone, int customerNumber, bool mailing, decimal purchaseAmount)
            : base(name, address, phone, customerNumber, mailing)
        {
            _purchaseAmount = purchaseAmount;
            //_discountLevel = CalculateDiscountLevel();
            
        }

        
    }
}
