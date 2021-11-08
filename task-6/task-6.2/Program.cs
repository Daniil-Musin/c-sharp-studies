using System;

namespace task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter the x of your dot: ");
                double userXofDot = Math.Round(double.Parse(Console.ReadLine()), 4);
                Console.Write("Enter the y of your dot: ");
                double userYofDot = Math.Round(double.Parse(Console.ReadLine()), 4);
                Console.WriteLine($"your dot is ({userXofDot}, {userYofDot})");
                Console.WriteLine($"Does it belong to the (>=2, >=0) or (>=1, <=-1)? {CheckBelonging(userXofDot, userYofDot)}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"==={error.Message}===");
            }
            


            Console.WriteLine("///type to exit");
            Console.ReadKey();
        }

        static string CheckBelonging(double xOfDot, double yOfDot)
        {
            bool belongingToArea1 = (xOfDot >= 2 && yOfDot >= 0);
            // (>=2, >=0)
            bool belongingToArea2 = (xOfDot >= 1 && yOfDot <= -1);
            // (>=1, <=-1)
            return (belongingToArea1 ^ belongingToArea2 ? "Yes" : "No");
        }
    }
}
