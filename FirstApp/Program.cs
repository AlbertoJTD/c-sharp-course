using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle = new Circle(); // New Circle object type

			double result = circle.CalculateArea(5);
            Console.WriteLine(result);
        }
	}

	class Circle
	{
		const double PI = 3.1416; // Property of Circle class

		public double CalculateArea(int radio) // Method class
		{
			return PI * Math.Pow(radio, 2);
		}
    }
}