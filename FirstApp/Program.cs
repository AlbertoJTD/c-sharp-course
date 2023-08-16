using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Example 1
			Create delegate object pointing to Greetings() */
			//DelegateObject delegateObject = new DelegateObject(WelcomeMessage.Greetings);
			DelegateObject delegateObject = new DelegateObject(WelcomeMessage.Greetings);

			// Use delegate to call the method Greetings
			//delegateObject();

			delegateObject("C sharp");


			/* Example 2
			Create delegate object pointing to Bye() */
			delegateObject = new DelegateObject(GoodbyeMessage.Bye);

			// Use delegate to call the method Greetings
			//delegateObject();
			delegateObject("Butterfly");
		}

		// delegate object
		//delegate void DelegateObject();
		delegate void DelegateObject(string message);
	}

	class WelcomeMessage
	{
		public static void Greetings() => Console.WriteLine($"Hello world!");
		public static void Greetings(string msj) => Console.WriteLine($"Hello world! -> {msj}");
	}

	class GoodbyeMessage
	{
		public static void Bye() => Console.WriteLine($"See you later!");
		public static void Bye(string msj) => Console.WriteLine($"See you later! -> {msj}");
	}
}