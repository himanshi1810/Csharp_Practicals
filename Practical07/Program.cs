using Practical07.SOLIDPrinciples;

namespace Practical07
{
    class Program
    {
        static void Main()
        {
            //Single Responsibility Principle
            Console.WriteLine("Single Responsibility Principle");
            Employee employee = new Employee("Himanshi", 100000);
            TaxCalculator taxCalculator = new TaxCalculator();
            double tax = taxCalculator.CalculateTax(employee);
            Console.WriteLine($"Tax for {employee.Name} is {tax}");

            //Open Closed Principle
            Console.WriteLine();
            Console.WriteLine("Open Close Principle");
            Invoice invoice = new Invoice(1000, new RegularCustomerDiscount());
            Console.WriteLine($"Amount after discount for Regular Customer is {invoice.ApplyDiscount()}");
            invoice = new Invoice(1000, new PremiumCustomerDiscount());
            Console.WriteLine($"Amount after discount for Premium Customer is {invoice.ApplyDiscount()}");

            //Liskov Substitution Principle
            Console.WriteLine();
            Console.WriteLine("Liskov Substitution Principle");
            Rectangle rectangle = new Rectangle { Width = 10, Height = 20 };
            Console.WriteLine($"Area of Rectangle is {rectangle.GetArea()}");
            Square square = new Square { Side = 10 };
            Console.WriteLine($"Area of Square is {square.GetArea()}");

            //Interface Segregation Principle
            Console.WriteLine();
            Console.WriteLine("Interface Segregation Principle");
            IPrinter printer = new Printer();
            printer.Print();
            MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print();
            multiFunctionPrinter.Scan();
            multiFunctionPrinter.Fax();

            //Dependency Inversion Principle
            Console.WriteLine();
            Console.WriteLine("Dependency Inversion Principle");
            IEmailService emailService = new GmailService();
            EmailClient emailClient = new EmailClient(emailService);
            emailClient.NotifyCustomer();
        }
    }
}