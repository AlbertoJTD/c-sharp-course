using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Seasons seasons = Seasons.Summer;
			Seasons? allergy = null; // Null variable
			*/

			/*
			Bonus John = Bonus.Good;
            Console.WriteLine(John); // This prints 'Good' -> Gets the enum name

			double bonusJohn = (double)John;
            Console.WriteLine(bonusJohn); // This prints '300' -> Gets the enum value
			*/

			Employee John = new Employee(Bonus.Excellent, 800);
            Console.WriteLine($"John's salary: {John.GetSalary()}");
        }
	}

	class Employee
	{
		private double salary;
		private Bonus bonus;

        public Employee(Bonus employeeBonus, double salary)
        {
			this.bonus = employeeBonus;
			this.salary = salary;
        }

		public double GetSalary()
		{
			return salary + (double)bonus;
		}
    }

	enum Bonus
	{
		Low = 100,
		Normal = 200,
		Good = 300,
		Excellent = 400
	}

	/*
	enum Seasons
	{
		Spring,
		Summer,
		Fall,
		Winter
	}*/
}