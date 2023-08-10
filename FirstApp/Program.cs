using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Circle circle = new Circle(); // New Circle object type

			//double result = circle.CalculateArea(5);
   //         Console.WriteLine(result);


			ConvertEuroToDollar convertMoney = new ConvertEuroToDollar();
			//convertMoney.euro = 1.45;
			convertMoney.ModifyEuroValue(1.45);
			Console.WriteLine(convertMoney.Convert(50));
        }
	}

	class Circle
	{
		private const double PI = 3.1416; // Property of Circle class

		public double CalculateArea(int radio) // Method class
		{
			return PI * Math.Pow(radio, 2);
		}
    }

	class ConvertEuroToDollar
	{
		public double euro = 0.9108;

		public double Convert(double amount)
		{
			return amount * euro;
		}

		// Accessors
		public void ModifyEuroValue(double newValue)
		{
			if (newValue > 0)
			{
				euro = newValue;
			}
		}
	}
}