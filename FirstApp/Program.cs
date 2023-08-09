using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("First number: ");
			int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
			int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum: {n1 + n2}");
        }
	}
}