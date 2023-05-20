using MusinDaniilTask5;

namespace MusinDaniilTask5_Tests
{
    public class Tests
    {


        [Test]
        public void TestSelectNumbers()
        {
            int[] arr = { 2, 55, 33, 11, 999 };
            int[] sortArr = { 11, 33, 55 };
            var SelectM = NumberSorting.SelectDistinctTwoDigitOddNums;
            Assert.AreEqual(sortArr, SelectM(arr, 0));

            int[] arr2 = { 222, -111, -250, -250, 551, 551,550, 55, 55 };
            int[] sortArr2 = { 55 };
            Assert.AreEqual(sortArr2, SelectM(arr2, 2));
            int[] arr3 = { 1, 2, 3, 4, 4, 4, 3, 3, 3, 33, 33, 5000, 5001 };
            int[] sortArr3 = { 33 };
            Assert.AreEqual(sortArr3, SelectM(arr3, 1));
            Assert.Pass();
        }

        [Test]
        public void TestCalculateClientTime()
        {
     /*     { CliendID; Year; Month; Duration; }*/
            Record[] db = {
                 new Record(0, 2002, 0, 1500),
                  new Record(1, 2004, 1, 24),
                   new Record(1, 2002, 1, 22),
                    new Record(1, 2004, 2, 11),
                     new Record(1, 2002, 1, 1660),
                      new Record(4, 2007, 4, 1000),
                       new Record(4, 2001, 4, 1000),
                        new Record(4, 2004, 4, 1000),
                         new Record(8, 2002, 8, 999),
                          new Record(8, 2002, 9, 999),
                           new Record(9, 2007, 5, 2222),
                            new Record(11, 2000, 0, 2700)
            };

            NumberSorting.CalculateClientTime(db);
            Assert.Pass();
 
        }
    }
}