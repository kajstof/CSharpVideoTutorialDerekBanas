using System;
using System.Collections.Generic;
using System.Text;

namespace derek_csharp_06
{
    class Animal
    {
        private string name;
        private string sound;
        public const string Shelter = "Derek's Home for Animals";

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
            }
        }

        public Animal()
        {
            Random rnd = new Random();
            idNum = rnd.Next(1, 23123142);
        }

        public string Name { get => name; set => name = value; }

        public string Owner { get; set; } = "No owner";

        private int numOfAnimals;
        private int idNum;

        public int NumOfAnimals { get => numOfAnimals; set => numOfAnimals += value; }
    }
}
