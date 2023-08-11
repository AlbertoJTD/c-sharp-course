using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Horse horse = new Horse("Mustang");
			Human human = new Human("John Wick");
			Gorilla gorilla = new Gorilla("Joe");

			gorilla.Climb();

            Console.WriteLine(gorilla.getName());
            Console.WriteLine(horse.getName());
            Console.WriteLine(human.getName());
        }
	}

	class Mammal
	{
		private string name;

        public Mammal(string name)
        {
			this.name = name;
        }

        public void Breath()
		{
            Console.WriteLine("I can breathe");
        }

		public void Eat()
		{
            Console.WriteLine("I am eating");
        }

		public string getName()
		{
			return name;
		}
	}

	class Horse : Mammal
	{
		// this calls the parent constructor ->  Mammal
		public Horse(string horseName) : base(horseName) { }

        public void Gallop()
		{
			Console.WriteLine("I am able to gallop...");
		}
	}

	class Human : Mammal
	{
        public Human(string humanName) : base(humanName) { }

        public void Think()
		{
			Console.WriteLine("I am thinking");
		}
	}

	class Gorilla : Mammal
	{
        public Gorilla(string gorillaName) : base(gorillaName) { }

        public void Climb()
		{
			Console.WriteLine("I am climbing");
		}
	}
}