using System;

namespace derek_csharp_12
{
    struct Rectangle<T>
    {
        private T width;
        private T length;

        public T Width { get => width; set => width = value; }
        public T Length { get => length ; set => length = value; }

        public Rectangle(T width, T length) : this()
        {
            this.width = width;
            this.length = length;
        }

        public string GetArea()
        {
            double dblWidth = Convert.ToDouble(Width);
            double dblLenght = Convert.ToDouble(Length);
            return $"{Width} * {Length} = {dblWidth * dblLenght}";
        }
    }
}
