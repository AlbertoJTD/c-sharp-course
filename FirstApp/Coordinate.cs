using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
	class Coordinate
	{
        public Coordinate()
        {
        }

        public Coordinate(int x, int y)
        {
            Console.WriteLine($"Coordinate: ({x},{y})");
        }
    }
}
