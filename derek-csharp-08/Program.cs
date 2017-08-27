using System;
using System.Text;

namespace derek_csharp_08
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Warrior krzys = new Warrior("Krzyś", 1000, 120, 40);
            Warrior grzes = new Warrior("Grześ", 1000, 120, 40);
            Battle.StartFight(krzys, grzes);
            Console.ReadKey();
        }
    }
}
