using System;
using System.Numerics;

namespace derek_csharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bi = 10;
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.000000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            DateTime dt = new DateTime(1986, 3, 2);
            Console.WriteLine("Day of Week : {0}", dt.DayOfWeek);
            dt = dt.AddDays(4);
            dt = dt.AddMonths(1);
            dt = dt.AddYears(1);
            Console.WriteLine("New date : {0}", dt.Date);
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());
            BigInteger bigNum = BigInteger.Parse("123123123124124124124124124");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas : {0:n4}", 23000);

            Console.ReadKey();
        }
    }
}
