using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello user!");
                Console.Write("Enter your x, please: ");
                double inputX = double.Parse(Console.ReadLine());
                Console.WriteLine($"The answer will be: {CalculateFunction(inputX)}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("///type to exit");
            Console.ReadKey();
        }

        static double CalculateFunction(double x)
        {
            if (Math.Sin(x) > 0.5)
            {
                return 1;
            }
            else if (Math.Sin(x) < -0.5)
            {
                return Math.Sin(x);
            }
            else
            {
                return 0;
            }

            throw new Exception("CalculateFunction has gone deadly wrong");
        }
    }
}
