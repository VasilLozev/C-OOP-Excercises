using System;


namespace ClassBoxData
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
		private double length;

		public double Length
		{
			get { return length; }
			private set {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format("{0} cannot be zero or negative.", "Length" ));
                }
                length = value;
            }
        }
		private double width;

		public double Width
        {
			get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format("{0} cannot be zero or negative.", "Width"));
                }
                width = value;
            }
		}
		private double height;

		public double Height
        {
			get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format("{0} cannot be zero or negative.", "Height"));
                }
                height = value;
            }
        }
        public double SurfaceArea()
        {
            return Length * Width * 2 + Length * Height * 2 + Width * Height * 2;
        }
        public double LateralSurfaceArea()
        {
            return Length * Height * 2 + Width * Height * 2;
        }
        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
