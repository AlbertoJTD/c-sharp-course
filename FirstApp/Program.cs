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
			int[] numbers = new int[4];
			numbers[0] = 1;
			numbers[1] = 2;
			numbers[2] = 4;
			numbers[3] = 8;

			ProcessData(numbers);

			Console.WriteLine("\nAfter modifying the values:: ");
			PrintData(numbers);
        }

		static void ProcessData(int[] data)
		{
            Console.WriteLine("Before modifying values: ");
            PrintData(data);

			for (int i = 0; i < data.Length; i++)
			{
				data[i] += 10;
			}
        }

		static void PrintData(int[] data)
		{
			foreach (int i in data)
			{
				Console.WriteLine(i);
			}
		}
	}
}