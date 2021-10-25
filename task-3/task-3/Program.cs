using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            Console.WriteLine("Enter your x, please:");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"This is what you get: {EquationSolver(Math.PI * x)}");
            Console.WriteLine("////Type to exit");
            Console.ReadKey();
        }

        static double EquationSolver(double x)
        {
            return 
                2 * Math.Cos(1 / (Math.Pow(x, 2.0) + 2)) / (Math.Pow(x, 3.0) + 1);
        }
    }
}
