using System;
namespace Practical03
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Creating an object of the Team class --> INHERITANCE
            Team team = new Team();
            team.TeamName = "ABCD";
            //Calling the printInfo method from the main method
            Console.WriteLine(team.printInfo());

            //Creating an object of the Duck and Bird class --> POLYMORPHISM
            Bird myBird = new Bird();
            Duck myDuck = new Duck();
            //fails because a parent class instance lacks child-specific properties and methods.
            //Duck myDuck = new Bird(); 
            Bird myDuck2 = new Duck(); //Dynamic Data Binding
            //Calling the Voice method from the main method
            myBird.Voice();
            myDuck.Voice();
            myDuck2.Voice();

            //Creating an object of the laptop class --> ENCAPSULATION
            Laptop laptop = new Laptop();
            laptop.Brand = "Dell";
            laptop.Model = "Inspiron";
            //fails because a private method is not accessible from outside the class.
            //laptop.MotherBoardInfo();
            //Calling the LaptopDetails method from the main method
            laptop.LaptopDetails();
        }
    }
}