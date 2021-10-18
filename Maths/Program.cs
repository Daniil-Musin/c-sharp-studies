using System;

namespace Maths
{
    class Program
    {   
        static void Main(string[] args)
        {
            int justNumber = 2;
            const double gravityAcceleration = 9.8;
            
            Console.WriteLine(justNumber);
            Console.WriteLine(justNumber++);
            Console.WriteLine(++justNumber);
            Console.WriteLine(gravityAcceleration);
            Console.WriteLine(double.MaxValue);
            Console.ReadKey();
            var l = 0x91;
            Console.WriteLine(l.GetType());


        }
    }
}
