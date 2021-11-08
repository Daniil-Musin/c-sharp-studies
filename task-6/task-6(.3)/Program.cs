using System;

namespace task_6_._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! You're playing chess for whites");
            Console.WriteLine("Whites have a knight, Blacks have a queen");
            try
            {
                Console.Write("Enter a position for the white knight: ");
                string whiteKnightPosition = TranslateFirstCharToNumber(Console.ReadLine());

                Console.Write("Enter a position for the black queen: ");
                string blackQueenPosition = TranslateFirstCharToNumber(Console.ReadLine());



                if (whiteKnightPosition == blackQueenPosition)
                {
                    throw new ArgumentException("pieces cannot be placed on the same square");
                } 
                else if (
                    CheckIfKnightCanTakeASquare(whiteKnightPosition, blackQueenPosition) 
                    || 
                    CheckIfQueenCanTakeASquare(blackQueenPosition, whiteKnightPosition))
                {
                    throw new ArgumentException("фигуры не могут находиться под боем друг друга");
                }
                else
                {
                    Console.Write("Everything is fine; \nSo, choose a position for the white knight to move to: ");
                    string nextKnightPosition = TranslateFirstCharToNumber(Console.ReadLine());
                    Console.WriteLine(
                        CheckIfThisIsPossibleForKnightToMove(whiteKnightPosition, blackQueenPosition, nextKnightPosition) 
                        ? "This move is possible. Congratulations!" 
                        : "This move is not possible; try another one");
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("///type to exit");
            Console.ReadKey();
        }

        static string TranslateFirstCharToNumber(string inputPosition)
        {
            inputPosition = inputPosition.ToLower();

            if (inputPosition.Length > 2)
            {
                throw new ArgumentException("You must enter a valid position in a format of (oneletter)(onenumber), like \"a1\" or \"B2\"");
            }
            else if (
                (inputPosition[0] - 96) > 8 || (inputPosition[1] > '8') 
                ||
                (inputPosition[0] - 96) < 1 || (inputPosition[1] < '1'))
            {
                throw new ArgumentException("You must enter a valid position in a range from (a1) to (h8)");
            }

            return (inputPosition[0] - 96).ToString() + inputPosition[1];
        }

        static bool CheckIfQueenCanTakeASquare(string queenPosition, string squarePosition)
        {
            return
            ((queenPosition[0] == squarePosition[0]
                    &&
            !(queenPosition[1] == squarePosition[1]))
                ||
            (!(queenPosition[0] == squarePosition[0])
                    &&
            queenPosition[1] == squarePosition[1]))

            ^

            (Math.Abs(queenPosition[0] - squarePosition[0]) 
            == 
            Math.Abs(queenPosition[1] - squarePosition[1]));
        }

        static bool CheckIfKnightCanTakeASquare(string knightPosition, string squarePosition)
        {
            return 
            (Math.Abs(knightPosition[0] - squarePosition[0]) == 1
                && Math.Abs(knightPosition[1] - squarePosition[1]) == 2) 
            ^
            (Math.Abs(knightPosition[0] - squarePosition[0]) == 2 
                && Math.Abs(knightPosition[1] - squarePosition[1]) == 1);
        }

        static bool CheckIfThisIsPossibleForKnightToMove(string prevKnightPosition, string currQueenPosition, string nextKnightPosition)
        {
            return
            CheckIfKnightCanTakeASquare(prevKnightPosition, nextKnightPosition)
            &&
            !CheckIfQueenCanTakeASquare(currQueenPosition, nextKnightPosition);
        }
    }
}
