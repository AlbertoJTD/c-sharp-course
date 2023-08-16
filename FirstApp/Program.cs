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

			//MathOperations operations = new MathOperations(num => num * num);
			MathOperations operations = new MathOperations((n1, n2) => n1 + n2);

			Console.WriteLine(operations(3,2));
        }

		//delegate int MathOperations(int number);
		delegate int MathOperations(int n1, int n2);


		//public static int SquareNumber(int num)
		//{
		//	return num * num;
		//}
	}

	class People
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
    }
}