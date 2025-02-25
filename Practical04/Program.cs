namespace Practical04
{
    //Enum is for creating an option about which user want to select which givw constatnt values to the variable
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of Student class is created
            Student student = new Student();
            Console.WriteLine("Enter Student Name: ");
            string? inputName = Console.ReadLine();
            student.Name = inputName ?? string.Empty;
            Console.WriteLine("Enter Marks of 5 Subjects: ");
            for (int i = 0; i < 5; i++)
            {
                //Do while loop is checking the input is between 0 and 100
                decimal mark;
                do
                {
                    Console.Write($"Enter mark {i + 1}: ");
                    //TryParse is used to check the input is decimal or not
                    while (!decimal.TryParse(Console.ReadLine(), out mark))
                    {
                        Console.Write("Invalid input! Enter a valid number: ");
                    }
                    //If the input is not between 0 and 100 then it will print the message
                    if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Marks must be between 0 and 100. Please enter again.");
                    }

                } while (mark < 0 || mark > 100);
                //Assigning the marks to the Marks array
                student.Marks[i] = mark;
            }
            //Run this menu until user enter 0
            int option;
            do
            {
                //Creating a Menu for the user to select the option
                Console.WriteLine("Enter Option:\n 0.Exit from the Program \n 1.Aggregate Marks\n 2.Minimum Marks\n 3.Maximum Marks\n 4.Grade\n");
                option = Convert.ToInt32(Console.ReadLine());
                //Switch is used to select the option which user want to select
                switch ((Options)option)//Typecasting the option to Options enum
                {
                    //Case 1 is for calculating the average marks
                    case Options.Aggregate:
                        Console.WriteLine("Aggregate Marks: " + student.CalculateAverage());
                        break;
                    //Case 2 is for calculating the minimum marks
                    case Options.MinMark:
                        Console.WriteLine("Minimum Marks: " + student.Marks.Min());
                        break;
                    //Case 3 is for calculating the maximum marks
                    case Options.MaximumMark:
                        Console.WriteLine("Maximum Marks: " + student.Marks.Max());
                        break;
                    //Case 4 is for calculating the grade of the student
                    case Options.Grade:
                        Console.WriteLine("Grade: " + student.GetGrade());
                        break;
                    // Case 0 is for exiting from the program
                    case 0:
                        Console.WriteLine("Exiting From The Program");
                        break;
                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            } while (option != 0);
        }
    }
}