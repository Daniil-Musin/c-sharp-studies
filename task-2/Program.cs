using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hi there! I'm the Square calculator
Enter the side's length of your square in integer:");

            double sideLength = Math.abs(double.Parse(Console.ReadLine()));

            Console.WriteLine(
                "The perimeter is " +
                CalculatePerimeter(sideLength) +
                " and the area is " +
                CalculateArea(sideLength)
                );
            Console.WriteLine(@"
////Type to exit");
            Console.ReadKey();

        }

        static double CalculatePerimeter(double side)
        {
            return side * 4;
        }

        static double CalculateArea(double side)
        {
            return side * side;
        }
    }
}
