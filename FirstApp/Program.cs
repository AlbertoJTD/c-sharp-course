using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Do you want to get into a while loop?");
			string result = Console.ReadLine();

			// Infinity loop
			while (result != "no")
			{
				Console.WriteLine("While loop executing...");
			}

			Random num = new Random();
            Console.WriteLine(num.Next(0, 100));
        }
	}
}