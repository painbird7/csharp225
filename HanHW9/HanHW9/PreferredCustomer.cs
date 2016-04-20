using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanHW9
{
    class PreferredCustomer : Customer
    {
        private decimal _purchaseAmount;
        private decimal _discount;
        private string _emailAddress;

        // Constructor
        public PreferredCustomer()
        {
            _purchaseAmount = 0;
            _discount = 0;
        }

        // PurchaseAmount property
        public decimal PurchaseAmount
        {
            get { return _purchaseAmount; }
            set { _purchaseAmount = value; }
        }

        // Discount property
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
    }
}
