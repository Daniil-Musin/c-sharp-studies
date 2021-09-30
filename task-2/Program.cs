using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hi there! I'm the Square calculator
Enter the side's length of your square in integer:");

            int squareLength = int.Parse(Console.ReadLine());
            PerimeterCalculator(squareLength);
            AreaCalculator(squareLength);
            Console.WriteLine(
                "The perimeter is " +
                PerimeterCalculator(squareLength) +
                " and the area is " +
                AreaCalculator(squareLength)
                );
            Console.WriteLine(@"
////Type to exit");
            Console.ReadKey();

        }

        static int PerimeterCalculator(int arg)
        {
            return arg * 4;
        }

        static int AreaCalculator(int arg)
        {
            return arg * arg;
        }
    }
}
