using System;

namespace task_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello user!\nEnter your integer: ");
                int number = int.Parse(Console.ReadLine());
                ShowMaxAndMinDigits(number);

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        static void ShowMaxAndMinDigits(int number)
        {
            
            for (int i = 9; i > -1; i--)
            {
                if (Convert.ToString(number).Contains(Convert.ToString(i)))
                {
                    Console.WriteLine($"Maximum digit is: {i}");
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToString(number).Contains(Convert.ToString(i)))
                {
                    Console.WriteLine($"Minimum digit is: {i}");
                    break;
                }
            }

        }
    }
}
