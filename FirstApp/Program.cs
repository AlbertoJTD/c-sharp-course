using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			consoleMessage();

            Console.WriteLine("Number 1: ");
            int n1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Number 2: ");
			int n2 = int.Parse(Console.ReadLine());

			sum(n1, n2);
		}

		static void consoleMessage()
		{
			Console.WriteLine("Hello from consoleMessage");
		}

		static void sum(int a, int b)
		{
            Console.WriteLine($"Sum: {a + b}");
        }
	}
}