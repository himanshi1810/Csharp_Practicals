using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical02
{
    //1st step :- Define the class
    class Customer_Account
    {
        //2nd step :- Define the variables
        public string bank_name;
        long customer_accountNo;
        string customer_name;

        //3rd Step :- Define the Parameterized Constructor
        public Customer_Account(long accountNo, string customerName)
        {
            this.customer_accountNo = accountNo;
            this.customer_name = customerName;
        }

        //4th Step :- Define the Method
        public void printInfo()
        {
            Console.WriteLine("Bank Name : " + bank_name);
            Console.WriteLine("Customer Account No : " + customer_accountNo);
            Console.WriteLine("Customer Name : " + customer_name);
        }

    }
}
