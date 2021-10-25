using System;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            var w = InputDouble("w");
            var v = InputDouble("v");
            Console.WriteLine($"Is dot ({w}, {v}) inside the square?: {Logicator3(w, v)}");

            var a = InputInt("a");
            var b = InputInt("b");
            var c = InputInt("c");
            Console.WriteLine($"Only one of these can be divided by 5: {Logicator2(a, b, c)}\n");

            Console.Write("Enter a number: ");
            var number = double.Parse(Console.ReadLine());
            Console.WriteLine($"[{number}] is bigger than 5 and lesser than 0: {Logicator1(number)}");

            Console.Write("Enter hexadecimal two-digit x: ");
            byte x = Convert.ToByte(Console.ReadLine(), 16);
            Console.WriteLine($"x = {Convert.ToString(x, 2)}");
            Console.WriteLine($"~x = {Convert.ToString(~x, 2).Substring(24)}\n");
            Console.Write("Enter hexadecimal two-digit y: ");
            byte y = Convert.ToByte(Console.ReadLine(), 16);
            Console.WriteLine($"y = {Convert.ToString(y, 2)}");
            Console.WriteLine($"~y = {Convert.ToString(~y, 2).Substring(24)}]\n");

            Console.WriteLine($"x & y = {Convert.ToString(x & y, 2)}");
            Console.WriteLine($"x | y = {Convert.ToString(x | y, 2)}");
            Console.WriteLine($"x ^ y = {Convert.ToString(x ^ y, 2)}");

            Console.WriteLine("/// Type to exit");
            Console.ReadKey();
        }

        static bool Logicator1(double alpha)
        {
            return !(alpha > 0 && alpha < 5);
        }

        static bool Logicator2(double a, double b, double c)
        {
            //return !((a % 5 == 0) ^ (b % 5 == 0) ^ (c % 5 == 0));
            return (!(a % 5 == 0) && (b % 5 == 0) && (c % 5 == 0)) ||
                ((a % 5 == 0) && !(b % 5 == 0) && (c % 5 == 0)) ||
                ((a % 5 == 0) && (b % 5 == 0) && !(c % 5 == 0));
        }

        static int InputInt(string name)
        {
            Console.Write($"Enter {name}: ");
            return int.Parse(Console.ReadLine());
        }

        static bool Logicator3(double w, double v)
        {
            
            return w <= 1 && w >= 0 && v <= 1 && v >= 0 && (Math.Pow(w, 2) + Math.Pow(v - 1, 2) >= 1 || Math.Pow(w - 1, 2) + Math.Pow(v, 2) >= 1);
        }

        static double InputDouble(string name)
        {
            Console.Write($"Enter {name}: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
