using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> numbers = new Stack<int>();

            // Add elements to the Queue
            foreach (int num in new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })
            {
				numbers.Push(num);
            }

            // Read Queue
            Console.WriteLine("Read Stack:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

			// Delete items from the queue
			Console.WriteLine("\nDelete element of the Stack:");
			numbers.Pop();
			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}