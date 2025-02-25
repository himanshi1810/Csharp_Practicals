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
            AverageMarks = Marks.Average(); 
            return AverageMarks;
        }
        //Method GetGrade is pattern matching with switch which is used to return the grade of the student according to the average marks
        public string GetGrade(decimal marks)
        {
            int marksInt = Convert.ToInt32(marks);
            switch (marksInt)
            {
                case > 90:
                    return "A";
                case > 80:
                    return "B";
                case > 70:
                    return "C";
                case < 70:
                    return "D";
                default:
                    return "Having Exception";
            }
        }
    }
}
