using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Horse horse = new Horse();
			Human human = new Human();
			Gorilla gorilla = new Gorilla();

			gorilla.Climb();
        }
	}

	class Mammal
	{
		public void Breath()
		{
            Console.WriteLine("I can breathe");
        }

		public void Eat()
		{
            Console.WriteLine("I am eating");
        }
	}

	class Horse : Mammal
	{
		public void Gallop()
		{
			Console.WriteLine("I am able to gallop...");
		}
	}

	class Human : Mammal
	{
		public void Think()
		{
			Console.WriteLine("I am thinking");
		}
	}

	class Gorilla : Mammal
	{
		public void Climb()
		{
			Console.WriteLine("I am climbing");
		}
	}
}