using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee(1200, 250);
			employee.ModifySalary(employee, 100);

            Console.WriteLine(employee);
        }
	}

	public struct Employee
	//public class Employee
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

		public void ModifySalary(Employee emp, double increase)
		{
			emp.baseSalary += increase;
			emp.commission += increase;
		}
    }
}