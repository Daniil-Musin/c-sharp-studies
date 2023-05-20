using System.Data;

namespace MusinDaniilTask5
{
    public abstract class NumberSorting
    {
        /*1. Написать метод, который по заданному массиву целых чисел 
         * и заданному порядковому номеру возвращает массив целых чисел, 
         * полученный из исходного массива следующим образом: 
         * начиная с заданного порядкового номера в новый массив включаются только 
         * положительные нечётные двузначные числа. Новый массив должен быть упорядочен 
         * по возрастанию и не должен содержать одинаковые числа.Метод должен 
         * быть написан с использованием только ОДНОГО оператора.*/
        public static int[] SelectDistinctTwoDigitOddNums(int[] array, int startIndex) 
        {
            var skipSet = new HashSet<int>();
            // если бы можно было использовать больше одного оператора - вставил бы .Distinct()
            IEnumerable<int> query = array[startIndex..].ToHashSet().ToArray().OrderBy((num) =>
            {
                int score = int.MinValue;
                if ((num % 2 == 1) &&
                    (num > 9 && num < 100))
                {
                    score = num;
                } else {
                    skipSet.Add(num);
                }
                return score;
            });
            var queryArr = query.ToArray();
            int skipCount = skipSet.ToArray().Length;
            return queryArr[skipCount..];
        }


        /*2. Написать метод, который для каждого месяца определяет
         * суммарную продолжительность занятий всех клиентов за все 
         * года и выводит на консоль вначале суммарную продолжительность, 
         * а затем номер месяца, а затем сведения о каждом месяце выводит 
         * на консоль построчно(упорядочивать по убыванию суммарной продолжительности, 
         * а при равной продолжительности — по  возрастанию номера месяца)*/

        
        public static void CalculateClientTime(Record[] recordsArr)
        {
            
            var groupedQuery = recordsArr.GroupBy(
                    rec => rec.Month,
                    (key, group) =>
                    {
                        var currDurationSum = group.Sum((el) => el.Duration);
                        return new {
                            Month = key,
                            Items = group.ToArray(),
                            DurationSum = currDurationSum
                        };
                    });
            
            var orderedQuery = groupedQuery
                .OrderBy(group => group.Month)
                .OrderByDescending(group => group.DurationSum);

            var AlltimeDurationSum = groupedQuery.Sum(gr => gr.DurationSum);
            Console.WriteLine("Время занятий за всё время: " + AlltimeDurationSum);
            foreach (var entry in orderedQuery)
            {
                Console.WriteLine("Месяц: " + entry.Month);
                Console.WriteLine("Время занятий: " + entry.DurationSum);
            }

        }
    }

    public struct Record
    {
        public int CliendID;
        public int Year;
        public int Month;
        public int Duration;
        public Record(int cid, int y, int m , int d)
        {
            CliendID = cid;
            Year = y;
            Month = m;
            Duration = d;
        }
    }

}