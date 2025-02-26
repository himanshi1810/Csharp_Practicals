namespace Practical07
{
    //Open Closed Principle :- In this by using inheritance and interface we can extend the functionality of the class without modifying it.
    //Creating an Interface for discount calculation
    public interface IDiscount
    {
        double GetDiscount(double amount);
    }
    //Creating Different claaes for different discount calculation
    public class RegularCustomerDiscount : IDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount - 0.05 * amount;
        }
    }
    public class PremiumCustomerDiscount : IDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount - 0.1 * amount;
        }
    }
    //Creating a class for calculating the discount
    //Invoice class follows OCP (It does not change when we add new discounts)
    public class Invoice
    {
        public double Amount { get; set; }
        private readonly IDiscount _discountStrategy;
        public Invoice(double amount, IDiscount discountStrategy)
        {
            Amount = amount;
            _discountStrategy = discountStrategy;
        }

        public double ApplyDiscount() => _discountStrategy.GetDiscount(Amount);
    }
}
