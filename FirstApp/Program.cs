using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();
			numbers.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

			// Create Predicate
			Predicate<int> myPredicate = new Predicate<int>(EvenNumber);

			// Store all numbers that match the predicate condition
			List<int> evenNumbers =  numbers.FindAll(myPredicate);

			// Print even numbers
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

		static bool EvenNumber(int number) => number % 2 == 0;
	}
}