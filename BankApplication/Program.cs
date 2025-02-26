using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Account customer = new Customer_Account(123456789, "GAUTAM LATHIYA");
            customer.BankName = "STATE BANK OF INDIA";

            // Display the information of the customer
            customer.printInfo();
        }
    }
}
