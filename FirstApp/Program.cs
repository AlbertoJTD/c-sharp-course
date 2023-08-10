using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			checked // Verify if there is an error
			{
				int num = int.MaxValue; // Gets the maximun value of an int type
				int result = num + 30; // It should be out of int range
				Console.WriteLine(result);
			}
		}
	}
}