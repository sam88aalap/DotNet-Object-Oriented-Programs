using System;

namespace CompanyOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create Products
            Product product1 = new Product() { PId = 1, ProductName = "iPhone 13", ProductPrice = 68000 };
            Product product2 = new Product() { PId = 2, ProductName = "iPhone 13 pro", ProductPrice = 112000 };
            Product product3 = new Product() { PId = 3, ProductName = "iPhone 13 pro max", ProductPrice = 127000 };
            Product product4 = new Product() { PId = 4, ProductName = "iPhone 12", ProductPrice = 55000 };
            Product product5 = new Product() { PId = 5, ProductName = "iPhone SE", ProductPrice = 34000 };
            Product product6 = new Product() { PId = 6, ProductName = "iPhone 13 mini", ProductPrice = 60000 };

            //2.Create Company
            Company company = new Company() { CompanyID = 1001, CompanyName = "Apple" };

            //3.Add Products to the Company
            company.AddProduct(product1);
            company.AddProduct(product2);
            company.AddProduct(product3);
            company.AddProduct(product4);
            company.AddProduct(product5);
            company.AddProduct(product6);

            //4.Create Customer
            Customer customer1 = new Customer() { CustomerId = 100, CustomerName = "Samuel Jacksom", MobileNumber = "9234567812" };
            Customer customer2 = new Customer() { CustomerId = 101, CustomerName = "Mark Hamill", MobileNumber = "7812563721" };
            Customer customer3 = new RegisteredCustomer(10) { CustomerId = 102, CustomerName = "Jim Parsons", MobileNumber = "9826738912" };

            //5.Add Customers to Company
            company.AddCustomer(customer1);
            company.AddCustomer(customer2);
            company.AddCustomer(customer3);

            //6.Add Company to the Customer
            customer1.Company = company;
            customer2.Company = company;
            customer3.Company = company;

            //7.Create Order
            Order order1 = new Order() { OrderId = 1, OrderDate = DateTime.UtcNow };
            Order order2 = new Order() { OrderId = 2, OrderDate = DateTime.UtcNow };
            Order order3 = new Order() { OrderId = 3, OrderDate = DateTime.UtcNow };
            Order order4 = new Order() { OrderId = 4, OrderDate = DateTime.UtcNow };
            Order order5 = new Order() { OrderId = 5, OrderDate = DateTime.UtcNow };
            Order order6 = new Order() { OrderId = 6, OrderDate = DateTime.UtcNow };

            //8.Add Order to Customer
            order1.Customer = customer1;
            order2.Customer = customer3;
            order3.Customer = customer2;
            order4.Customer = customer1;
            order5.Customer = customer3;
            order6.Customer = customer2;

            //9.Add Customer to Order
            customer1.AddOrder(order1);
            customer1.AddOrder(order2);
            customer2.AddOrder(order3);
            customer2.AddOrder(order4);
            customer3.AddOrder(order5);
            customer3.AddOrder(order6);

            //10.Create OrderItem
            OrderItem orderItem1 = new OrderItem() { Quantity = 1 };
            OrderItem orderItem2 = new OrderItem() { Quantity = 2 };
            OrderItem orderItem3 = new OrderItem() { Quantity = 1 };
            OrderItem orderItem4 = new OrderItem() { Quantity = 3 };
            OrderItem orderItem5 = new OrderItem() { Quantity = 1 };
            OrderItem orderItem6 = new OrderItem() { Quantity = 4 };
            OrderItem orderItem7 = new OrderItem() { Quantity = 2 };
            OrderItem orderItem8 = new OrderItem() { Quantity = 3 };
            OrderItem orderItem9 = new OrderItem() { Quantity = 1 };
            OrderItem orderItem10 = new OrderItem() { Quantity = 2 };

            //11.Add Products to OrderItem
            orderItem1.Product = product1;
            orderItem2.Product = product2;
            orderItem3.Product = product3;
            orderItem4.Product = product4;
            orderItem5.Product = product5;
            orderItem6.Product = product1;
            orderItem7.Product = product6;
            orderItem8.Product = product4;
            orderItem9.Product = product1;
            orderItem10.Product = product2;

            //12.Add OrderItem to Order
            order1.AddOrderItems(orderItem1);
            order2.AddOrderItems(orderItem2);
            order3.AddOrderItems(orderItem3);
            order4.AddOrderItems(orderItem4);
            order5.AddOrderItems(orderItem5);
            order6.AddOrderItems(orderItem6);
            order1.AddOrderItems(orderItem7);
            order2.AddOrderItems(orderItem8);
            order3.AddOrderItems(orderItem9);
            order4.AddOrderItems(orderItem10);
            order5.AddOrderItems(orderItem1);
            order6.AddOrderItems(orderItem2);

            //13.Display Company Data
            DisplayCompanyInfo(company);
        }

        private static void DisplayCompanyInfo(Company company)
        {
            Console.WriteLine("Company Data");
            DrawLine(40, "-");
            Console.WriteLine($"CompanyID: {company.CompanyID}\tCompanyName: {company.CompanyName}");
            DrawLine(40, "-");
            foreach (var customer in company.GetCustomers())
            {
                Console.WriteLine();
                Console.WriteLine($"CustomerId: {customer.CustomerId}" + $"\tCustomer Name: {customer.CustomerName}");
                Console.WriteLine();
                Console.WriteLine($"Customer Total Order Value\t\t\t\t{customer.GetOrdersTotal()}");
                //if (customer is RegisteredCustomer)
                //{
                //    var regCustomer = (RegisteredCustomer)customer;
                //    var discount = regCustomer.Discount;
                //    var discountAmount = customer.GetOrdersTotal() * 10 / 100;
                //    var afterDiscount = customer.GetOrdersTotal() - discountAmount;
                //    Console.WriteLine($"Total Customer Order Value after Discount\t\t{afterDiscount}");
                //}
                DrawLine(65, "-");
                foreach (var order in customer.GetOrders())
                {
                    Console.WriteLine($"OrderID:{order.OrderId}\tOrder Date: {order.OrderDate}");
                    DrawLine(65, "-");
                    Console.WriteLine("ProductId\tName\t\tPrice\tQuantity\tAmount");
                    DrawLine(65, "-");

                    foreach (var orderItem in order.GetOrderItems())
                    {

                        Console.WriteLine($"{orderItem.Product.PId}\t\t{orderItem.Product.ProductName}" +
                            $"\t{orderItem.Product.ProductPrice}\t{orderItem.Quantity}" +
                            $"\t\t{orderItem.GetAmount()}");
                    }
                    DrawLine(65, "-");
                    Console.WriteLine($"Total\t\t\t\t\t\t\t{order.GetOrderTotal()}");
                    
                }
                DrawLine(65, "^");
                DrawLine(65, "^");
            }
        }

        private static void DrawLine(int range, string symbol)
        {
            for (int i = 0; i < range; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
