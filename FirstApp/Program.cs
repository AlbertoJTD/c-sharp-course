using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*People p1 = new People();
			p1.Name = "Jonny Cage";
			p1.Age = 40;

			People p2 = new People();
			p2.Name = "John";
			p2.Age = 39;*/

			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

			//foreach (int number in evenNumbers)  Console.WriteLine(number);
			//evenNumbers.ForEach(num => Console.WriteLine(num));
			evenNumbers.ForEach(num => {
                Console.WriteLine($"Hello {num}");
				Console.WriteLine(num);
            });
		}
	}

	class People
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
    }
}