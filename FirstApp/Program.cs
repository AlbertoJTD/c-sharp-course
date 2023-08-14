using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee john = new Employee("John");
			//john.Set_salary(1000);
			//Console.WriteLine($"John's _salary: {john.Get_salary()}");

			john.SALARY = 1000;
			john.SALARY += 200;
            Console.WriteLine($"John's _salary: {john.SALARY}");
        }
	}

	class Employee
	{
		// Class fields
		private string name;
		private double salary;

		// V1
        /*public double SALARY
		{
			get { return this.salary; }
			set { this.salary = Evaluatesalary(value); }
		}*/

		// V2 ->  Expression bodied
		public double SALARY
		{
			get => this.salary;
			set => this.salary = EvaluateSalary(value);
		}

		public Employee(string name)
        {
            this.name = name;
        }

		private double EvaluateSalary(double salary)
		{
			if (salary < 0) return 0;
			else return salary;
		}

		/*
		public void SetSalary(double salary)
		{
			if (salary < 0)
			{
                Console.WriteLine("The salary cannot be negative");
				this.salary = 0;
            }
            else
            {
				this.salary += salary;
            }
        }

		public double GetSalary()
		{
			return this.salary;
		}
		*/
	}
}