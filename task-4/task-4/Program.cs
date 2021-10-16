using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            Console.WriteLine($"Your answer is {CalculateFullExpression()}"); ;
            Console.WriteLine("/// type to exit");
            Console.ReadKey();
        }

        static double CalculateFullExpression() 
        {
            double answer = CalculateSmallerPart(3, 5) * CalculateSmallerPart(3, 7) * CalculateSmallerPart(5, 5);
            return Math.Round(answer, 2);
        }

        static double CalculateSmallerPart(double a, double b)
        {
            return (Math.Sin(a) + Math.Sqrt(a)) / (Math.Cos(b) + Math.Sqrt(b));
        }
    }
}
