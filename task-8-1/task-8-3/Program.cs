using System;

namespace task_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello user!\nEnter your a (1 < a < 1,5): ");
                double a = double.Parse(Console.ReadLine());
                if (!(a > 1 & a < 1.5))
                    throw new Exception("out of given range");
                Console.WriteLine("Your numbers out of that a: ");
                PrintNumbers(a);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }

        static void PrintNumbers(double limit)
        {
            for (double n = 2; 1 + 1 / n >= limit; n++)
            {
                Console.WriteLine(1 + 1 / n);
            }
        }
    }
}
