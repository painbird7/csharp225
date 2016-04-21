using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class PreferredCustomer : Customer
    {
        // Constructor
        public PreferredCustomer(string name, string address, string phone, string customerNumber, bool mailing, decimal purchaseAmount)
            : base(name, address, phone, customerNumber, mailing)
        {
            discountLevel = CalculateDiscountLevel();
            
        }

        // PurchaseAmount property
        

        // Discount property
        public decimal discountLevel;

        public decimal CalculateDiscountLevel()
        {
            decimal purchaseAmount = 
            decimal calValue;
            if ( - 500)
            {

            }
        }
    }
}
