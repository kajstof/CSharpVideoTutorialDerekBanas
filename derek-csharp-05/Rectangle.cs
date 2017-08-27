namespace derek_csharp_05
{
    partial class Program
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length = 1, double width = 1)
            {
                this.length = length;
                this.width = width;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
