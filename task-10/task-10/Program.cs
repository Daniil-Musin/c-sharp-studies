using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            while (true)
            {
                try
                {
                    int m = TakeNumber("m", 5, 20); //rows
                    int n = TakeNumber("n", 5, 20); //columns

                    var Randomizer = new Random();
                    int[,] intCollection = new int[m,n];
                    for (int i = 0; i < intCollection.GetUpperBound(0) + 1; i++)
                    {
                        for (int j = 0; j < intCollection.GetUpperBound(1) + 1; j++)
                        {
                            intCollection[i, j] = Randomizer.Next(0, 100);
                        }

                    }
                    
                    PrintArray(intCollection);

                    int numForCheck = TakeNumber("number for checking");
                    if (CheckIsThereANumberBiggerThanGiven(numForCheck, intCollection))
                    {
                        bool endFlag = false;
                        for (int i = 0; !endFlag & i < intCollection.GetUpperBound(0) + 1; i++)
                        {
                            for (int j = 0; !endFlag & j < intCollection.GetUpperBound(1) + 1; j++)
                            {
                                if (numForCheck < intCollection[i, j])
                                {
                                    Console.WriteLine($"there is a number that is bigger than yours: [{intCollection[i, j]}, row: {i}, column: {j}]");
                                    endFlag = true;
                                }
                            }
                        };
                    }
                    else
                        Console.WriteLine("There is NO number that is bigger than yours;");

                    Console.WriteLine("\nArithemtical means of your collection:");
                    double[] arrayOfArithmeticalMeans = FindArithmeticMeanForEveryColumn(intCollection);
                    for (int i = 0; i < arrayOfArithmeticalMeans.Length; i++)
                        Console.WriteLine($"column's index: {i}; column's arithmetical mean: {arrayOfArithmeticalMeans[i]}");


                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                };
            };

            Console.WriteLine("///// Type to exit");
            Console.ReadKey();
        }


        static bool CheckIsThereANumberBiggerThanGiven(int givenNumber, int[,] array)
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (givenNumber < array[i, j])
                        return true;
                }
            }
            return false;
        }

        static double[] FindArithmeticMeanForEveryColumn(int[,] initialArray)
        {
            int BoundOfRows = initialArray.GetUpperBound(0) + 1;
            int BoundOfColumns = initialArray.GetUpperBound(1) + 1;

            double[] AllArithmeticMeans = new double[BoundOfColumns];
            
            for (int column = 0; column < BoundOfColumns; column++)
            {
                for (int row = 0; row < BoundOfRows; row++)
                    AllArithmeticMeans[column] += initialArray[row, column];
                        
            }

            for (int i = 0; i < BoundOfColumns; i++)
                AllArithmeticMeans[i] /= BoundOfRows;

            return AllArithmeticMeans;
        }


        static int TakeNumber(string numberName, int floor, int ceiling)
        {
            Console.Write($"Enter your {numberName} (from {floor} to {ceiling}): ");
            int givenNumber = int.Parse(Console.ReadLine());
            if (givenNumber > ceiling || givenNumber < floor) throw new Exception("your number is out of given range");
            return givenNumber;
        }

        static int TakeNumber(string numberName)
        {
            Console.Write($"Enter your {numberName}: ");
            int givenNumber = int.Parse(Console.ReadLine());
            return givenNumber;
        }

        static void PrintArray(int[,] array)
        {
            Console.WriteLine("Here is an array of randomized numbers from 0 to 99:");
            foreach (var item in array)
                ;

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine($"row {i}");
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            
        }


    }
}
