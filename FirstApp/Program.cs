using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//         Console.WriteLine("First number: ");
			//int n1 = int.Parse(Console.ReadLine());

			//         Console.WriteLine("Second number: ");
			//int n2 = int.Parse(Console.ReadLine());

			//         Console.WriteLine($"Sum: {n1 + n2}");

			const int VALUE1 = 10;
			const int VALUE2 = 20;
            Console.WriteLine("Values: {0} - {1}", VALUE1, VALUE2);

			const double PI = 3.1416;
            Console.WriteLine("Type the radius: ");
			double radius = double.Parse(Console.ReadLine());

			//double area = radius * radius * PI;
			double area = Math.Pow(radius, 2) * PI;

			Console.WriteLine($"The circle area is {area}");
        }
	}
}