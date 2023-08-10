using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Choose transportation (car, train, airplane) :");
			string transportation = Console.ReadLine();

			switch (transportation)
			{
				case "car":
                    Console.WriteLine("This is a car");
                    break;

				case "train":
					Console.WriteLine("This is a train");
					break;

				case "airplane":
					Console.WriteLine("This is an airplane");
					break;

				default:
					Console.WriteLine("The value entered does not exist");
					break;
			}
        }
	}
}