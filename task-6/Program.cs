using System;

namespace task_6_._1_
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter m: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"m is {m}, n is {n}, and only one of them is even: {Convert.ToBoolean(m % 2 ^ n % 2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("/// type to exit");
            Console.ReadKey();
        }
    }
}
