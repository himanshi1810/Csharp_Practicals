using System;

namespace Practical03
{
    //Creating Class Bird that have one method Voice
    class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    //Creating Class Duck that extends the Bird class with same method but different implementation
    class Duck : Bird
    {
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
