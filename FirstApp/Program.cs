using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee john = new Employee("John");
		}
	}

	class Employee
	{
		private string name;
		private double salary;

        public Employee(string name)
        {
            this.name = name;
        }

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
    }
}