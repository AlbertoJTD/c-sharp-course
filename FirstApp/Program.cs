using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<People> people = new List<People>();

			People p1 = new People();
			p1.Name = "Jonny Cage";
			p1.Age = 40;

			People p2 = new People();
			p2.Name = "John";
			p2.Age = 39;

			people.AddRange(new People[] { p1, p2 });

			Predicate<People> findJohnPredicate = new Predicate<People>(ExistsJohn);
			bool john = people.Exists(findJohnPredicate);

			if (john) Console.WriteLine("John is on the list");
			else Console.WriteLine("There is no one named John");
        }

		static bool ExistsJohn(People people) => people.Name == "John";
	}

	class People
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
    }
}