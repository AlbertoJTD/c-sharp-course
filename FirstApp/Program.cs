using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Guess the random number");

			Random random = new Random();
			int randomNumber = random.Next(0, 100);
            bool guessed = false;
			int attemps = 0;

            while (!guessed)
            {
				attemps++;

				Console.WriteLine("Type the number: ");
				int userValue = int.Parse(Console.ReadLine());

				if (userValue > randomNumber)
				{
                    Console.WriteLine("The typed value is greather than the generated number\n");
				}
				else if (userValue < randomNumber)
				{
					Console.WriteLine("The typed value is less than the generated number\n");
				}
				else
				{
                    Console.WriteLine($"\n\nYou guessed the number: {randomNumber}, Attemps: {attemps}");
					guessed = true;
				}
			}
		}
	}
}