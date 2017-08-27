using System;
using System.Globalization;
using System.Text;

namespace derek_csharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var intVal = 1234;
            Console.WriteLine("intVal Type : {0} | {1}", intVal.GetType(), typeof(int));
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray[0] : {0}\nrandomArray[1] : {1}\nrandomArray[2] : {2}", randomArray[0].GetType(), randomArray[1].GetType(), randomArray[2].GetType());
            Console.WriteLine("randomArray.Length : {0}", randomArray.Length);
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };
            Console.WriteLine($"MD Value : {custNames.GetValue(1, 1)}");
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine($"custNames[{i}][{j}] : {custNames[i, j]}");
                }
            }
            int[] randNums = { 0, 1, 4, 9, 2 };
            Array.Reverse(randNums);
            Array.Sort(randNums);
            Console.WriteLine("1 at Index : {0}", Array.IndexOf(randNums, 1));
            Console.WriteLine("99 at Index : {0}", Array.IndexOf(randNums, 99));
            PrintArray(randNums, "ForEach");
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, startInd, length);
            PrintArray(destArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is important", 256);
            Console.WriteLine("Capacity : {0}" ,sb.Capacity);
            Console.WriteLine("Capacity : {0}" ,sb2.Capacity);
            Console.WriteLine("Length : {0}" ,sb.Length);
            sb2.AppendLine("\nMore important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.ReadKey();
        }

        private static void PrintArray(int[] randNums, string v)
        {
            foreach (int k in randNums)
            {
                Console.WriteLine("{0} : {1}", v, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}
