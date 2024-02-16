using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class CustomerBiz  //publisher
    {
        public event EventHandler<CustomerEventArgument> CustomerAdded;
        public void AddCustomer(Customer cust)
        {
            Console.WriteLine("Added a new Cu");

            System.Threading.Thread.Sleep(1000);

            //Raise the event when Customer is added
            this.CustomerAdded(this, new CustomerEventArgument
            { CustomerName = cust.CustName, Store = "ABC Store" });
        }
    }
}
