using System;


namespace task_zachot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! \nЭта программа считает количества гласных в строке;");
            Console.WriteLine('\u0040');
            while (true)
            {
                
                try
                {
                    string inputString = TakeString();
                    if (!CheckIfAllOfThemAreCyrillic(inputString))
                        throw new Exception("В вашей строке присутствуют не-кириллические знаки;");
                    CountRussianVowels(inputString);

                    Console.WriteLine("///Type to exit");
                    Console.ReadKey();
                    break;
                }

                catch (Exception error)
                {
                    Console.WriteLine($"====================================\n{error.Message}\n====================================\n");
                }

                

                
            };
                

        }

        static void CountRussianVowels(string userInput)
        {
            char[] dictionary = { 'а', 'э', 'о', 'ы', 'и', 'у', 'я', 'е', 'ё', 'ю' };

            int globalCount = 0;
            for (int i = 0; i < dictionary.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < userInput.Length ; j++)
                {
                    if (dictionary[i] == userInput[j] 
                        ||
                        Convert.ToInt32(userInput[j]) == Convert.ToInt32(dictionary[i]) - 32)
                    {
                        ++count;
                        ++globalCount;
                    }
                }
                Console.WriteLine($"{dictionary[i]}: {count}");
               
            }
            Console.WriteLine($"Всего гласных: { globalCount}");
        }

        static string TakeString()
        {
            Console.Write("Введите свою строку (на кириллице): ");
            string userInput = Console.ReadLine();
            
            return userInput;
        }

        static bool CheckIfAllOfThemAreCyrillic(string userInput)
        {
            char[] arrayForCheck = userInput.ToCharArray();
            foreach (var item in arrayForCheck)
            {
                if ((Convert.ToInt32(item) > Convert.ToInt32('\u04ff') 
                        ||
                    Convert.ToInt32(item) < Convert.ToInt32('\u0400'))
                    &&
                    (Convert.ToInt32(item) > Convert.ToInt32('\u0040')))
                    return false;
            }
            return true;
            // Включен не только русский алфавит, но и весь кириллический + цифры;
        }
    }
}
