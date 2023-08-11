using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Math; // import all methods of the Math class

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] data = ReadData();

            Console.WriteLine("\nThis is your array: ");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

		static int[] ReadData()
		{
            Console.WriteLine("How many elements do you need in the array?");
			int numElements = int.Parse(Console.ReadLine());

			int[] numbers = new int[numElements];

            Console.WriteLine("\nType the numbers: ");
			for (int i = 0; i < numElements; i++)
			{
                Console.WriteLine($"Numbers [{i}] => ");
                numbers[i] = int.Parse(Console.ReadLine());
			}

			return numbers;
        }
	}
}