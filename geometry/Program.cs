using System;

namespace geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter the two points for 1st Line:");

            Console.WriteLine("Enter x1 coordinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 coordinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2 coordinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 coordinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double distanceForLine1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine("Enter the two points for 2nd Line:");

            Console.WriteLine("Enter x1 coordinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 coordinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2 coordinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 coordinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double distanceForLine2 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            if (distanceForLine1 == distanceForLine2)
            {
                Console.WriteLine("The lines are of equal distance");
            }
            else
            {
                Console.WriteLine("The lines are not of equal distance");
            }
        }
    }
}