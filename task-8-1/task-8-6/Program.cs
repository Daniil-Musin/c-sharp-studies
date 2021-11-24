using System;
using System.Linq;

namespace task_8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello user!\nEnter the number of your workers: ");
                uint workers = uint.Parse(Console.ReadLine());
                if (workers <= 0)
                    throw new Exception("It seems that you have no workers... That's pretty sad :(");
                Console.WriteLine("Prepare to enter a bunch of data...");
                EnterTheSalaries(workers);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }

        static void EnterTheSalaries(uint workers)
        {
            // Ну невозможно здесь без массивов...
            uint[][] arrayOfWorkers = new uint[3][];
            for (int j = 0; j < 3; j++)
            {
                arrayOfWorkers[j] = new uint[workers];
            }

            for (int m = 0; m < 3; m++)
            {
                for (int i = 0; i < workers; i++)
                {
                    Console.Write($"Worker #{i+1} in month #{m+1} earned: ");
                    arrayOfWorkers[m][i] = uint.Parse(Console.ReadLine());

                    if (m > 1) //последняя стадия
                        Console.WriteLine($"///Maximum earned by worker #{i + 1}: " + ShowMaximumEarned(
                            arrayOfWorkers[0][i],
                            arrayOfWorkers[1][i],
                            arrayOfWorkers[2][i]));
                }
                Console.WriteLine();
            }
            FindTheMostPaidWorkersInMonths(arrayOfWorkers);
        }

        static uint ShowMaximumEarned(uint a, uint b, uint c)
        {
            return Math.Max(
                        Math.Max(a, b),
                        Math.Max(b, c));
        }

        static void FindTheMostPaidWorkersInMonths(uint[][] arrayOfWorkers)
        {
            
            for (int m = 0; m < 3; m++)
            {
                uint best = arrayOfWorkers[m].Max();
                Console.WriteLine($"The most paid worker of month #{m + 1} is worker #{Array.IndexOf(arrayOfWorkers[m], best) + 1}\nHe earned: {best}");
            }
        }
    }
}
