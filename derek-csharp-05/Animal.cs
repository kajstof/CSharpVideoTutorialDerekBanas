using System;

namespace derek_csharp_05
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
            numOfAnimals++;
        }

        public Animal() : this("No name", "No sound") { }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", Name, Sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumOfAnimals()
        {
            return numOfAnimals;
        }
    }
}
