using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			People p1 = new People();
			p1.Name = "Jonny Cage";
			p1.Age = 40;

			People p2 = new People();
			p2.Name = "John";
			p2.Age = 39;

			//ComparePeople compareAge = (ageP1, ageP2) => ageP1 == ageP2;
			//Console.WriteLine(compareAge(p1.Age, p2.Age));

			ComparePeople compareName = (ageP1, ageP2) => ageP1 == ageP2;
			Console.WriteLine(compareName(p1.Name, p2.Name));
        }

		//public delegate bool ComparePeople(int ageP1, int ageP2);
		public delegate bool ComparePeople(string name1, string name2);
	}

	class People
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
    }
}