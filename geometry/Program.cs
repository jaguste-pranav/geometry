using System;

namespace geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two points:");

            Console.WriteLine("Enter x1 coordinate: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 coordinate: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2 coordinate: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 coordinate: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine("The distnace between these points is " + distance);

        }
    }
}