using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        private List<Product> products = new List<Product>();

        private List<Customer> customers = new List<Customer>();

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.products;
        }

        /// <summary>
        /// Method to Return all customers
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return this.customers;
        }
    }
}
