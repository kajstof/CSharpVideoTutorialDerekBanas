using System;
using System.Collections.Generic;

namespace derek_csharp_12
{
    class Program
    {
        public delegate void Arithmetic(double num1, double num2);
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numList = new List<int>();
            numList.Add(24);
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });
            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(1);
            Console.WriteLine("Num of Animals : {0}", animalList.Count);
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }
            Stack<Animal> stack = new Stack<Animal>();
            Queue<Animal> queue = new Queue<Animal>();
            Dictionary<int, Animal> dictionary = new Dictionary<int, Animal>();
            Console.WriteLine();
            int x = 5, y = 4;
            Animal.GetSum(ref x, ref y);
            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());
            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());
            Console.WriteLine();
            Arithmetic add, sub, addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            Console.WriteLine("Add 6 & 10");
            add(6, 10);
            Console.WriteLine("Add & Subtract 10 & 4");
            addSub(10, 4);

            Console.ReadKey();
        }
    }
}
