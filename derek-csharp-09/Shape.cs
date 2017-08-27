using System;

namespace derek_csharp_09
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Area();
    }
}
