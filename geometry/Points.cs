using System;
using System.Collections.Generic;
using System.Text;

namespace geometry
{
    class Points
    {
        private int x, y;
        public void setXCoordinate(int x)
        {
            this.x = x;
        }

        public void setYCoordinate(int y)
        {
            this.y = y;
        }

        public int getXCoordinate()
        {
            return this.x;
        }

        public int getYCoordinate()
        {
            return this.y;
        }

        public static double distance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The distance between two points is "+ distance);

            return distance;
        }
    }
}
