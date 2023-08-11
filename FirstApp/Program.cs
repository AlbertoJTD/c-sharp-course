using System;
using System.Runtime.ConstrainedExecution;
using static System.Math; // import all methods of the Math class

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ages = new int[4];
			Console.WriteLine(ages[0]);

			ages[0] = 1;
			ages[1] = 2;
			ages[2] = 3;
			ages[3] = 4;

			//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine(numbers[3]);
        }
	}
}