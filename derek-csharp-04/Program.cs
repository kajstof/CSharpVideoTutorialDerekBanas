using System;

namespace derek_csharp_04
{
    class Program
    {
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void Main(string[] args)
        {
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
            Console.ReadKey();
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
    }
}
