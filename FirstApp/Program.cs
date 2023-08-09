using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(Sum(7, 5));
        }

		// Method Overloading
		static int Sum(int a, int b) => a + b;

		static double Sum(int a, double b) => a + b;

		static int Sum(int n1, int n2, int n3) => n1 + n2 + n3;
	}
}