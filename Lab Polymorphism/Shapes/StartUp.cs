using System;
using System.Drawing;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(555);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());

            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());

            Console.WriteLine(  circle.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}

