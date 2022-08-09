using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Method to total Order Amount
        /// </summary>
        /// <returns></returns>
        public double GetAmount()
        {
            return Product.ProductPrice * Quantity;
        }
    }
}

