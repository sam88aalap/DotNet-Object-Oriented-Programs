using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class RegisteredCustomer : Customer
    {
        public int Discount { get; }

        public RegisteredCustomer(int discount)
        {
            this.Discount = discount;
        }

        public override double GetOrdersTotal()
        {
            double total = 0;
            var orderValue = base.GetOrdersTotal();
            var discount = orderValue * this.Discount / 100;
            total = orderValue - discount;
            return total;
        }
    }
}
