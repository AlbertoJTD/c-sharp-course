using System;
using System.Runtime.ConstrainedExecution;
using static System.Math; // import all methods of the Math class

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//CalculateDistance();

			var myVariable = new { Name = "Alberth", Age = 20 }; // Anonymous classes
            Console.WriteLine(myVariable.Name);

			var test = new { Name = "Alberth", Age = "20" };
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