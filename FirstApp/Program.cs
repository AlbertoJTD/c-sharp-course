using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Horse horse = new Horse("Mustang");
			ITerrestrialMammals IMyHorse = horse; // substitution principle
			IJumpWithPaws IMyHorse2 = horse; // substitution principle


			//Human human = new Human("John Wick");
			//Gorilla gorilla = new Gorilla("Joe");

			Mammal animal = new Horse("Horse"); // substitution principle
			Mammal person = new Human("Brayan"); // substitution principle

			//Mammal[] myMammals = new Mammal[3];
			//myMammals[0] = animal;
			//myMammals[1] = person;
			//myMammals[2] = new Gorilla("King kong");

			//for (int i = 0; i < myMammals.Length; i++)
			//{
			//	myMammals[i].Think();
			//}

			Mammal myMammal = new Mammal("");
			myMammal.Breath();

			Whale whale = new Whale("Willy");
			whale.Swim();

			Console.WriteLine($"Horse number paws: {IMyHorse.NumberPaws()}"); // Interface method
			Console.WriteLine($"Number of paws used for jumping: {IMyHorse2.NumberPaws()}"); // Interface method
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

		public virtual void Think()
		{
			Console.WriteLine("Just Think");
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

	class Horse : Mammal, ITerrestrialMammals, IAnimalUsedSports, IJumpWithPaws
	{
		// this calls the parent constructor ->  Mammal
		public Horse(string horseName) : base(horseName) { }

		public void Gallop()
		{
			Console.WriteLine("I am able to gallop...");
		}

		int ITerrestrialMammals.NumberPaws()
		{
			return 4;
		}

		int IJumpWithPaws.NumberPaws()
		{
			return 2;
		}

		public string SportType()
		{
			return "Equestrian";
		}

		public bool IsOlimpic()
		{
			return true;
		}
	}

	class Human : Mammal
	{
		public Human(string humanName) : base(humanName) { }

		public override void Think()
		{
			Console.WriteLine("Overthink");
		}
	}

	class Gorilla : Mammal, ITerrestrialMammals
	{
		public Gorilla(string gorillaName) : base(gorillaName) { }

		public void Climb()
		{
			Console.WriteLine("I am climbing");
		}

		public override void Think()
		{
			Console.WriteLine("Think like a Gorilla");
		}

		public int NumberPaws()
		{
			return 2;
		}
	}

	class Whale : Mammal
	{
		public Whale(string name) : base(name) { }

		public void Swim()
		{
			Console.WriteLine("I am able to swim");
		}
	}