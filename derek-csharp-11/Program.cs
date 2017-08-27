﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace derek_csharp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code
            Console.WriteLine("-- ArrayList");
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "Turkey");
            ArrayList range = aList2.GetRange(0, 2);
            foreach (object o in range)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            foreach (object o in aList2)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            //aList2.RemoveAt(0);
            //aList2.RemoveRange(0, 2);
            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));
            string[] myArray = (string[])aList2.ToArray(typeof(string));
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);
            foreach (string s in custArrayList)
            {
                Console.WriteLine(s);
            }
            #endregion
            #region Dictionary
            Console.WriteLine("-- Dictionary");
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");
            superheroes.Remove("Barry West");
            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));
            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent : {test}");
            foreach(KeyValuePair<string, string>  item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            #endregion
            #region Queue
            Console.WriteLine("-- Queue");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove 1 : {0}", queue.Dequeue());
            Console.WriteLine("Peek 1 : {0}", queue.Peek());
            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(", ", numArray));
            //queue.Clear();
            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }
            #endregion
            #region Stack
            Console.WriteLine("-- Stack");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Peek 1 : {0}", stack.Peek());
            Console.WriteLine("Pop 1 : {0}", stack.Pop());
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));
            object[] numArray2 = stack.ToArray();
            Console.WriteLine(string.Join(", ", numArray2));
            //stack.Clear();
            foreach (object o in stack)
            {
                Console.WriteLine($"Queue : {o}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
