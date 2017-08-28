using System;
using System.Threading;

namespace derek_csharp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Print1);
            thread.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            Console.WriteLine();
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(100);
                num++;
            }
            Thread.Sleep(1200);
            Console.WriteLine("Thread Ends");
            BankAccount account = new BankAccount(10);
            Thread[] threads = new Thread[15];
            Thread.CurrentThread.Name = "main";
            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(account.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

            }
            Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);
            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            Thread t2 = new Thread(() => CountTo(10));
            t2.Start();
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadKey();
        }

        private static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Print1(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
    }
}