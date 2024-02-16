using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerBiz objCustomerBiz = new CustomerBiz();
            objCustomerBiz.CustomerAdded += onCustomerAdded;

            Customer newCustomer = new Customer
            {
                CustID = 1,
                CustName = "Test",
            };

            objCustomerBiz.AddCustomer(newCustomer);

        }

        private static void onCustomerAdded(object sender, CustomerEventArgument e) 
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Customer {e.CustomerName} added at store{e.Store}");

            Console.ForegroundColor= ConsoleColor.Green;
        }
    }
}
