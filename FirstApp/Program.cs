using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> numbers = new Queue<int>();

            // Add elements to the Queue
            foreach (int num in new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })
            {
				numbers.Enqueue(num);
            }

            // Read Queue
            Console.WriteLine("Read Queue:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

			// Delete items from the queue
			Console.WriteLine("\nDelete first element of the Queue:");
			numbers.Dequeue();
			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}