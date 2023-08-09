using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleMessage();

            Console.WriteLine("Number 1: ");
            int n1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Number 2: ");
			int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(n1, n2));
		}

		static void ConsoleMessage()
		{
			Console.WriteLine("Hello from consoleMessage");
		}


		//static int Sum(int a, int b)
		//{
		//          return a + b;
		//      }

		static int Sum(int a, int b) => a + b; // Returns an integer
	}
}