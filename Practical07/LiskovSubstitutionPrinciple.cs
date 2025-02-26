namespace Practical07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SOLIDPrinciples
    {
        //Liskov Substitution Principle
        //In this case, I demonstrate that a derived class should be able to replace the base class without affecting the functionality of the program.
        //Solution of Liskov Substitution Principle with Square and Rectangle
        //By using abstract class
        public abstract class Shape
        {
            public abstract int GetArea();
        }
        public class Rectangle : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public override int GetArea() => Width * Height;
        }
        //Square class follows the LSP
        public class Square : Shape
        {
            public int Side { get; set; }
            public override int GetArea() => Side * Side;
        }

    }

}
