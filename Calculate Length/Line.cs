using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate_Length
{
    internal class Line
    {
        public static double x1, y1, x2, y2, length_of_line;
        public static void Coordinates()
        {
            length_of_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1 , 2));
            Console.WriteLine("Length of line : " + length_of_line);
        }
    }
}
