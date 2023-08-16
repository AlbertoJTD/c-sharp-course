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

			MathOperations operations = new MathOperations(SquareNumber);
            Console.WriteLine(operations(3));
        }

		delegate int MathOperations(int number);

		public static int SquareNumber(int num)
		{
			return num * num;
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