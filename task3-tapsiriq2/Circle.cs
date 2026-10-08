using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq2
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
