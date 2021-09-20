using System;

namespace Daniil_Musin_task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("К Себе - Михаил Лермонтов");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
            Что не люблю ее, хотел
            Неизмеримое измерить,
            Любви безбрежной дать предел.
            Мгновенное пренебреженье
            Ее могущество опять
            Мне доказало, что влеченье
            Души нельзя нам побеждать;
            Что цепь моя несокрушима,
            Что мой теперешний покой
            Лишь глас залетный херувима
            Над сонной демонов толпой.");
            Console.ResetColor();
            Console.WriteLine(@"
Конец стиха
/////////
Type to exit");
            Console.ReadKey();
        }
    }
}
