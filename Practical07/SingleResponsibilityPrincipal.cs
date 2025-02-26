namespace Practical07
{
    //In this case, I demonstrate that one class should take only one responsibility.
    //Class Employee should only be responsible for Employee related operations.
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    //TaxCalculator class should only be responsible for calculating tax.
    internal class TaxCalculator
    {
        public double CalculateTax(Employee employee)
        {
            return employee.Salary * 0.3; //30% tax
        }
    }
}
