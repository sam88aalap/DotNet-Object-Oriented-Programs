using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        private List<OrderItem> orderItems = new List<OrderItem>();

        /// <summary>
        /// Method to add Order Items
        /// </summary>
        /// <param name="orderItem"></param>
        public void AddOrderItems(OrderItem orderItem)
        {
            this.orderItems.Add(orderItem);
        }

        /// <summary>
        /// Get all Order Items
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderItem> GetOrderItems()
        {
            return this.orderItems;
        }

        /// <summary>
        /// Method to get order total
        /// </summary>
        /// <returns></returns>
        public double GetOrderTotal()
        {
            double total = 0;
            foreach (var orderItem in this.orderItems)
            {
                total += orderItem.GetAmount();
            }
            return total;
        }
    }
}
