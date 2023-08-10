using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Type a number: ");
			bool isANumber = false;

			do
			{
				try
				{
					int num = int.Parse(Console.ReadLine());
					isANumber = true;
				}
				//catch (FormatException e)
				//{
    //                Console.WriteLine("You have entered text");
    //            }
				catch (Exception e) when (e.GetType() != typeof(FormatException)) // general exception excluding FormatException
				{
                    Console.WriteLine(e.Message);
                }
				catch (FormatException e)
				{
					Console.WriteLine("You have entered text");
				}
			} while (!isANumber);
		}
	}
}