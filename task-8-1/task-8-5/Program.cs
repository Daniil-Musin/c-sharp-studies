using System;

namespace task_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello user!\nEnter your first integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter your second integer: ");
                int b = int.Parse(Console.ReadLine());

                if (a == 0 & b == 0)
                    throw new Exception("at least one of your integers should not be 0");

                Console.WriteLine($"The greatest common divider of these is: {FindGreatestCommonDivider(a, b)}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            

            Console.ReadKey();
        }

        static int FindGreatestCommonDivider(int a, int b)
        {
            while (a != 0 & b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }
    }
}
