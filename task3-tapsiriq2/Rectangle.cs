using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq2
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
