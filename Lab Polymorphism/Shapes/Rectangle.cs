using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width)
        {
            Heigth = height;
            Width = width;
        }

        public int Heigth { get; private set; }
        public int Width { get; private set; }

        public override double CalculateArea()
        {
            return Heigth * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Heigth + 2 * Width;
        }
    }
}
