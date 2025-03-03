namespace Practical08
{
    //This class is inherited from User Class
    internal class Librarian : User
    {
        public string EmployeeId { get; private set; }
        public Librarian(string userId, string name, Address address, string employeeId)
            : base(userId, name, address)
        {
            EmployeeId = employeeId;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();//Call Base Class Method
            Console.WriteLine($"Employee ID: {EmployeeId}");
        }
    }
}
