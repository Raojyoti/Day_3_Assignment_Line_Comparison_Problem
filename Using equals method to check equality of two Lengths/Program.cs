using System;

namespace Using_equals_method_to_check_equality_of_two_Lengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for x1: ");
            Line.x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for x2: ");
            Line.x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for y1: ");
            Line.y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for y2: ");
            Line.y2 = Convert.ToInt32(Console.ReadLine());
            Line.Coordinates();

            Console.Write("\n");

            Console.Write("Enter value for x3: ");
            Line.x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for x4: ");
            Line.x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for y4: ");
            Line.y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for y5: ");
            Line.y4 = Convert.ToInt32(Console.ReadLine());
            Line.Coordinates1();
            Console.Write("\n");

            Line.Coordinates2();


        }
    }
}
