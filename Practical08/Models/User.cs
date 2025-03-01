namespace Practical08.Models
{
    //Here Encapsulation Is Demonstrated And Also we can Inherit from other classes
    public class User
    {
        public string UserId { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }

        public User(string userId, string name, Address address)
        {
            UserId = userId;
            Name = name; 
            Address = address;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User ID: {UserId}, Name: {Name}, Address: {Address}");
        }
    }
}
