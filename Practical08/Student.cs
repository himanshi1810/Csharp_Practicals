namespace Practical08
{
    //This class is inherited from the main User Class
    public class Student : User
    {
        public string StudentId { get; private set; }
        public Student(string userId, string name, Address address, string studentId)
            : base(userId, name, address)
        {
            StudentId = studentId;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class method to display User details
            Console.WriteLine($"Student ID: {StudentId}");
        }
    }
}
