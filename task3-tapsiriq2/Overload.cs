using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq2
{
    public static class Overload
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
