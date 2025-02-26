using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Customer_Account
    {
        /// <summary>
        /// Fields
        /// </summary>
        string bank_name;
        long customer_accountNo;
        string customer_name;

        /// <summary>
        /// Initializes a new instance of the Customer_Account class with the specified account number and customer name.
        /// </summary>
        /// <param name="accountNo">The customer's account number.</param>
        /// <param name="customerName">The customer's name.</param>
        public Customer_Account(long accountNo, string customerName)
        {
            this.customer_accountNo = accountNo;
            this.customer_name = customerName;
        }

        /// <summary>
        /// Gets or sets the name of the bank associated with the account.
        /// </summary>
        public string BankName
        {
            get { return bank_name; }
            set { bank_name = value; }
        }

        /// <summary>
        /// Prints the bank details including bank name, account number, and customer name to the console.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine("Bank Name: " + bank_name);
            Console.WriteLine("Account Number: " + customer_accountNo);
            Console.WriteLine("Customer Name: " + customer_name);
        }
    }
}
