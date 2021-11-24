using System;

namespace task_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello user!\nEnter your n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter your x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine($"Your answer: {CalculateSum(n, x)}");

                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine($"!!@@{error.Message}@@!!");
            }
        }

        static double CalculateSum(int n, double x)
        {
            double answer = 1;
            for (int i = 1; i < n + 1; i++)
            {
                answer += (double)(i + 1) / (double)(i + 2) * Math.Pow(x, i);
            }
            
            return answer;
        }
    }
}
