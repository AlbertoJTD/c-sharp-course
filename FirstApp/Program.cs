using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Type the number of the month: ");
			int month = int.Parse(Console.ReadLine());
			try
			{
				var result = MonthName(month);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException e)
			{
                Console.WriteLine($"Error: {e.Message}");
            }
		}

		public static string MonthName(int month)
		{
			switch (month)
			{
				case 1:
					return "January";
				case 2:
					return "February";
				case 3:
					return "March";
				case 4:
					return "April";
				case 5:
					return "May";
				case 6:
					return "June";
				case 7:
					return "July";
				case 8:
					return "August";
				case 9:
					return "September";
				case 10:
					return "October";
				case 11:
					return "November";
				case 12:
					return "December";
				default:
					throw new ArgumentOutOfRangeException(nameof(month), "The month must be between 1-12");
			}
		}
	}
}