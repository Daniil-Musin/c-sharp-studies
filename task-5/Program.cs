using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hello user! This is a TRANSLIT app
Enter your text, please:");
            Console.WriteLine(Transliterate(Console.ReadLine()));
            Console.WriteLine("/// Type to exit");
            Console.ReadKey();
        }

        static string Transliterate(string str)
        {

            string[] latinDictionary = { "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SHCH", "IE", "Y", "", "E", "YU", "YA" };
            string[] russianDictionary = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };

            for (int i = 0; i <= 32; i++)
            {
                str = str.ToUpper();
                str = str.Replace(russianDictionary[i], latinDictionary[i]);
                //str = str.Replace(rus_low[i], lat_low[i]);
            }
            return str;
        }
    }
}