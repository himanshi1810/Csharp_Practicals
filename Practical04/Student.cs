namespace Practical04
{
    //Student class is for storing the student name and marks of 5 subjects and calculate the average marks and grade of the student
    class Student
    {
        //Data member Name is for storing the name of the student
        public string Name = String.Empty;//Here Empty is used to assign the empty string to the Name
        //Data member Marks is for storing the marks of 5 subjects
        public decimal[] Marks = new decimal[5];
        //Static data member AverageMarks is for storing the average marks of the student
        static decimal AverageMarks;
        //Method CalculateAverage is for calculating the average marks of the student
        public decimal CalculateAverage()
        {
            decimal sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Marks[i];
            }
            AverageMarks = sum / 5;
            return AverageMarks;
        }
        //Method GetGrade is pattern matching with switch which is used to return the grade of the student according to the average marks
        public string GetGrade()
        {
            switch (AverageMarks)
            {
                case var d when d > 90:
                    return "A";
                case var d when d > 80:
                    return "B";
                case var d when d > 70:
                    return "C";
                case var d when d < 70:
                    return "D";
                default:
                    return "Having Exception";
            }
        }
    }
}
