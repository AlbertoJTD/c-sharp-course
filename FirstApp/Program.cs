﻿using System;
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
				catch (FormatException e)
				{
                    Console.WriteLine("Invalid value, try again");
                }
			} while (!isANumber);
		}
	}
}