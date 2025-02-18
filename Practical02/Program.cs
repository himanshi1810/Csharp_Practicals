namespace Practical02
{
    class Program
    {
        static void Main(string[] args)
        {
            //5th Step :- Define the Customer_Account object
            Customer_Account customer = new Customer_Account(123456789, "Himanshi Gandhi");

            //6th Step :- Initialize the bank_namw
            customer.bank_name = "ABCD Bank";

            //7th Step :- Call the Method
            customer.printInfo();
        }
    }
}