using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            FullEquationCalculator();
            Console.WriteLine("/// type to exit");
            Console.ReadKey();
        }

        static void FullEquationCalculator() 
        {
            double answer = smallCalc(3, 5) * smallCalc(3, 7) * smallCalc(5, 5);
            Console.WriteLine($"Your answer is {Math.Round(answer, 2)}");
        }

        static double smallCalc(double arg1, double arg2)
        {
            return (Math.Sin(arg1) + Math.Sqrt(arg1)) / (Math.Cos(arg2) + Math.Sqrt(arg2));
        }
    }
}
