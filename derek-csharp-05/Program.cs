using System;

namespace derek_csharp_05
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length : {0}", rect2.length);
            Animal fox = new Animal() { Name = "Red", Sound = "Raaww" };
            fox.MakeSound();
            Console.WriteLine("# of Animals : {0}", Animal.GetNumOfAnimals());
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 10, 5));
            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum doesn't has value");
            }
            Console.ReadKey();
        }
    }
}
