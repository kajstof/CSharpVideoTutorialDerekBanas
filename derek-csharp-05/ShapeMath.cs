﻿using System;

namespace derek_csharp_05
{
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if (string.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (string.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2 / 2);
            }
            else if (string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.141592 * Math.Pow(length1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
