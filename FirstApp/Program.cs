using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Example 1
			List<int> numbers = new List<int>(); // Declare a List

			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);
			numbers.Add(4);
			numbers.Add(5);
			numbers.Add(6);

			for (int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			// Example 2
			List<int> numbers2 = new List<int>(); // Declare a List
			int[] numbersList = new int[] { 7, 8, 9, 10, 11 };

			for (int i = 0; i < numbersList.Length; i++)
			{
				numbers2.Add(numbersList[i]);
			}

			// Example 3
			List<int> numbers3 = new List<int>(); // Declare a List
			Console.WriteLine("\nHow many elements do you need?");
			int numElements = int.Parse(Console.ReadLine());

			for (int i = 0; i < numElements; i++)
			{
				numbers3.Add(int.Parse(Console.ReadLine()));
			}

			for (int i = 0; i < numbers3.Count; i++)
			{
				Console.WriteLine(numbers3[i]);
			}

			// Example 4
			List<int> numbers4 = new List<int>(); // Declare a List
			Console.WriteLine("\n\nType as many elements as you need (0 to exit)...");
			int number = 1;
			do
			{
				number = int.Parse(Console.ReadLine());
				numbers4.Add(number);
			} while (number != 0);

			numbers4.RemoveAt(numbers4.Count - 1);
		}
	}
}