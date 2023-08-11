using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculateDistance();
        }

		static void CalculateDistance()
		{
			Coordinate pointA = new Coordinate();
			Coordinate pointB = new Coordinate(150, 90);

			double distance = pointA.DistanceTo(pointB);

            Console.WriteLine($"The distance is: {distance}");

			Console.WriteLine($"Objects created: {Coordinate.getCounterObjects()}");
        }
	}
}