using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(Sum(7, 5));
		}

		// Optional parameters
		static double Sum(int a, double b, double c=0)
		{
			return a + b + c;
		}

		static double Sum(int a, double b)
		{
			return a + b;
		}
	}
}