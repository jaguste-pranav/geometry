using System;
using System.Runtime.CompilerServices;

namespace geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Push");
            Points point_1 = new Points();
            Points point_2 = new Points();

            point_1.setXCoordinate(6);
            point_1.setYCoordinate(8);

            point_2.setXCoordinate(0);
            point_2.setYCoordinate(0);

            Points point_3 = new Points();
            Points point_4 = new Points();

            point_3.setXCoordinate(6);
            point_3.setYCoordinate(7);

            point_4.setXCoordinate(0);
            point_4.setYCoordinate(0);

            double distForline1 = Points.distance(point_1.getXCoordinate(), point_1.getYCoordinate(), point_2.getXCoordinate(), point_2.getYCoordinate());
            double distForline2 = Points.distance(point_3.getXCoordinate(), point_3.getYCoordinate(), point_4.getXCoordinate(), point_4.getYCoordinate());

            if(distForline1 == distForline2)
            {
                Console.WriteLine("The lines are of equal distance");
            }

            if(distForline1>distForline2)
            {
                Console.WriteLine("Line 1 is greater in length");
            }

            if (distForline2 > distForline1)
            {
                Console.WriteLine("Line 2 is greater in length");
            }
            //    Console.WriteLine("Enter the two points for 1st Line:");

            //    Console.WriteLine("Enter x1 coordinate: ");
            //    x1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter y1 coordinate: ");
            //    y1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter x2 coordinate: ");
            //    x2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter y2 coordinate: ");
            //    y2 = Convert.ToInt32(Console.ReadLine());

            //    double distanceForLine1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            //    Console.WriteLine("Enter the two points for 2nd Line:");

            //    Console.WriteLine("Enter x1 coordinate: ");
            //    x1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter y1 coordinate: ");
            //    y1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter x2 coordinate: ");
            //    x2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter y2 coordinate: ");
            //    y2 = Convert.ToInt32(Console.ReadLine());

            //    double distanceForLine2 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            //    if (distanceForLine1 == distanceForLine2)
            //    {
            //        Console.WriteLine("The lines are of equal distance");
            //    }

            //    if (distanceForLine1 > distanceForLine2)
            //    {
            //        Console.WriteLine("The line 1 is larger than line 2");
            //    }

            //    if (distanceForLine1 < distanceForLine2)
            //    {
            //        Console.WriteLine("The line 2 is larger than line 1");
            //    }
        }
    }
}