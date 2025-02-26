namespace Practical07
{
    //Interface Segregation Principle
    //In this case, I demonstrate that a class should not be forced to implement an interface that it does not use.
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    //The class that only use necessary interfaces so that it does not have to implement unnecessary methods.
    //A simple Printer class that only implements IPrinter interface
    public class Printer : IPrinter
    {
        public void Print() => Console.WriteLine("Print");
    }
    //A multifunctional printer that implements IPrinter, IScanner and IFax interfaces
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print() => Console.WriteLine("Print from advance printer");
        public void Scan() => Console.WriteLine("Scan from advance printer");
        public void Fax() => Console.WriteLine("Fax from advance printer");
    }
}
