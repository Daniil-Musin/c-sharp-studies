using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            Console.WriteLine(Transliterate(Console.ReadLine()));
        }

        static string Transliterate(string input)
        {
            string[] inputArray = input.Split("");

            return input;
        }
    }
}
