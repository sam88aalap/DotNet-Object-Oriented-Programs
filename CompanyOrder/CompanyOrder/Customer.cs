using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public Company Company { get; set; }

        private List<Order> orders = new List<Order>();

        /// <summary>
        /// Method to add orders
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        /// <summary>
        /// Method to get all orders
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetOrders()
        {
            return this.orders;
        }

        /// <summary>
        /// Method to get Customer Order Total
        /// </summary>
        /// <returns></returns>
        public virtual double GetOrdersTotal()
        {
            double total = 0;
            foreach (var order in this.orders)
            {
                total += order.GetOrderTotal();
            }
            return total;
        }
    }
}
