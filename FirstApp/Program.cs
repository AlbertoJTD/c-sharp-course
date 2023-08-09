using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello world");

			int age = 20;
			Console.WriteLine("Your age is " + age);
			Console.WriteLine($"Your age is {age}");

			Console.WriteLine($"Your age is {age++}");
			Console.WriteLine($"Your age is {++age}");

			// Intialize values
			int person1, person2, person3, person4;
			person1 = person2 = person3 = person4 = 30;

			// Convert from double to int
			double temperature = 34.5;
			int temperatureMexico = (int)temperature;
			Console.WriteLine(temperatureMexico);
        }
	}
}