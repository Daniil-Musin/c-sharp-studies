using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            try
            {
                // 8.1

                Console.WriteLine("=== tasks 8(1-5) ===");
                Console.Write("Enter your p (initial value): ");
                double p = double.Parse(Console.ReadLine());
                Console.Write("Enter your q (denominator): ");
                double q = double.Parse(Console.ReadLine());
                double[] geometricizedArray = FindGeometricProgression(p, q);

                // 8.2

                Console.WriteLine("\nfirst 20 values: ");
                PrintDoubleArray(geometricizedArray);

                // 8.3
                Console.WriteLine("");
                Console.WriteLine("\nsame array, but all elements are squared (and mutated): ");
                PrintDoubleArray(DoSquareElementsOfArray(geometricizedArray));

                // 8.4
                Console.WriteLine("");
                Console.WriteLine("\nthe geometric mean of it: " +
                    $"{FindGeometricMeanOfArray(geometricizedArray):f3}");

                // 8.5
                Console.WriteLine();
                Console.Write("\nEnter your k (multiplier): ");
                double k = double.Parse(Console.ReadLine());
                Console.WriteLine("And you get: ");
                double[] newBiggerArray = MultiplyElementsOfArray(geometricizedArray, k);
                PrintDoubleArray(newBiggerArray);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("///Type to exit");
            Console.ReadKey();
        }

        static double[] FindGeometricProgression(double initialValue, double denominator)
        {
            double[] productionsArray = new double[20];
            for (int i = 0; i < productionsArray.Length; i++)
            {
                productionsArray[i] = initialValue * denominator;
                initialValue *= denominator;
            }

            return productionsArray;
        }

        static double[] DoSquareElementsOfArray(double[] initialArray)
        {
            
            for (int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] *= initialArray[i];
                
            }

            return initialArray;
        }

        static void PrintDoubleArray(double[] givenArray)
        {
            foreach (double element in givenArray)
                Console.Write($"{element} ");
        }

        static double FindGeometricMeanOfArray(double[] givenArray)
        {
            double productionOfValues = 1;
            foreach (double value in givenArray)
                productionOfValues *= value;
                
            return Math.Pow(productionOfValues, 1 / givenArray.Length);
        }

        static double[] MultiplyElementsOfArray(double[] givenArray, double multiplier)
        {
            double[] newArray = new double[givenArray.Length];
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = givenArray[i] * multiplier;
            return newArray;
        }
    }
}
