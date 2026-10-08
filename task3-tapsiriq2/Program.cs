using FiqurlarApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                Console.WriteLine();

            }
            Console.WriteLine("overloaded methods:");

            double circleArea = Overload.CalculateArea(5);
            double rectangleArea = Overload.CalculateArea(4, 6);

            Console.WriteLine($"5 radiuslu daire sahesi: {Overload.CalculateArea(5)}");
            Console.WriteLine($"4 ve 6 olculu duzbucaqli sahesi: {Overload.CalculateArea(4, 6)}");

        }

    }
}