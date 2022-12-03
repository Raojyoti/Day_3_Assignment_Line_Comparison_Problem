using System;
using System.Collections.Generic;
using System.Text;

namespace Using_compareTo_method_to_compare_the_Lengths
{
    internal class Line
    {
        public static double x1, y1, x2, y2, length_of_line1, length_of_line2, x3, y3, x4, y4;
        public static void Coordinates()
        {
            length_of_line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line : " + length_of_line1);
        }
        public static void Coordinates1()
        {
            length_of_line2 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            Console.WriteLine("Length of line : " + length_of_line2);
        }
        public static void Coordinates2()
        {
            Console.WriteLine(length_of_line1.Equals(length_of_line2));
        }
        public static void Coordinates3()
        {
            Console.WriteLine(length_of_line1.CompareTo(length_of_line2));
        }
    }
}
