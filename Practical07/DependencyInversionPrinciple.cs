namespace Practical07
{
    //Dependency Inversion Principle
    //In this case, I demonstrate that high-level modules should not depend on low-level modules. Both should depend on abstractions.
    public interface IEmailService
    {
        void SendEmail(string message);
    }
    public class GmailService : IEmailService
    {
        public void SendEmail(string message) => Console.WriteLine($"Sending email using Gmail: {message}");
    }
    public class YahooService : IEmailService
    {
        public void SendEmail(string message) => Console.WriteLine($"Sending email using Yahoo: {message}");
    }
    public class EmailClient
    {
        private readonly IEmailService _emailService;
        public EmailClient(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public void NotifyCustomer()
        {
            _emailService.SendEmail("Your order has been shipped!");
        }
    }
}
