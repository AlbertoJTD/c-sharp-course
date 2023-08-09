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
		}
	}
}