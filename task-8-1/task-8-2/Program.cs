using System;

namespace task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello user!\nHow much numbers do you want to enter?: ");
                int quantityOfNumbers = int.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateProductOfNumbersGiven(quantityOfNumbers)}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }

        static double CalculateProductOfNumbersGiven(int cycles)
        {
            Console.Write("Enter your first number: ");
            double answer = double.Parse(Console.ReadLine());
            for (int i = 1; i < cycles; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                answer *= double.Parse(Console.ReadLine());
            }
            return answer;
        }
    }
}
