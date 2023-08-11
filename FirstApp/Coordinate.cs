using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
	class Coordinate
	{
        private int x, y;
        private static int counterObjects = 0;

        public Coordinate()
        {
            this.x = 0;
            this.y = 0;
            counterObjects++;
        }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
            counterObjects++;
        }

        public double DistanceTo(Coordinate point)
        {
            int xDifference = this.x - point.x;
            int yDifference = this.y - point.y;

            double result = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
            return result;
        }

        public static int getCounterObjects() => counterObjects;
    }
}
