using System;

namespace Calculate_Length
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
        }
    }
}
