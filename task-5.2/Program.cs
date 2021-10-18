using System;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = "клавиатура";
            Console.WriteLine($@"Hello user!
Given string is: {given}");
            string[] characterForOutput1 = 
                new string[] { 
                    given.Substring(6, 1),
                    given.Substring(4, 1),
                    given.Substring(2, 1),
                    given.Substring(8, 2)};

            string output1 = String.Join("", characterForOutput1);

            string[] characterForOutput2 =
                new string[] {
                    given.Substring(8, 1),
                    given.Substring(7, 1),
                    given.Substring(0, 1),
                    given.Substring(2, 1)};

            string output2 = String.Join("", characterForOutput2);

            Console.WriteLine($@"We can make from it something like that:
{output1} and {output2}
///type to exit");
            Console.ReadKey();
        }
    }
}
