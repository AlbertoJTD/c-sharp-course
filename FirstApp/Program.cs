using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee(1200, 250);

            Console.WriteLine(employee);
        }
	}

	class Employee
	{
		public double baseSalary, commission;

        public Employee(int baseSalary, int commission)
        {
			this.baseSalary = baseSalary;
			this.commission = commission;
        }

		public override string ToString()
		{
			return string.Format("Sallary and comission for employee ({0}, {1})", this.baseSalary, this.commission);
		}
    }
}