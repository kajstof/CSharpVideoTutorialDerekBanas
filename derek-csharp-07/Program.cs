using System;

namespace derek_csharp_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };
            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };
            grover.Sound = "Wooooooooof";
            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooooff",
                Sound2 = "Geeerrrrr"
            };
            monkey.MakeSound();
            spot.MakeSound();
            Console.ReadKey();
        }
    }
}
