using System;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double Radius { get; private set; }
        public override double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double per_cir = 0;
            double PI = 3.14;
            per_cir = 2 * PI * Radius;
            return per_cir;
        }
    }
}
