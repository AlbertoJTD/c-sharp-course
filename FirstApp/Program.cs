using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			WarehouseEmployee<Director> employees = new WarehouseEmployee<Director>(3);
			employees.AddElement(new Director(200));
			employees.AddElement(new Director(400));
			employees.AddElement(new Director(600));

			// There is an error because Student class does not implemenet IEmployee interface
			WarehouseEmployee<Student> estudents = new WarehouseEmployee<Student>(3);
			estudents.AddElement(new Student(20));
			estudents.AddElement(new Student(40));
			estudents.AddElement(new Student(60));

		}
	}

	class WarehouseEmployee<T> where T : IEmployee
	{
		private int counter = 0;
		private T[] employeeData;

        public WarehouseEmployee(int numberElements) => employeeData = new T[numberElements];

		public void AddElement(T obj)
		{
			employeeData[counter] = obj;
			counter++;
		}

		public T GetEmployee(int position)
		{
			return employeeData[position];
		}
    }

	class Student
	{
		private double age;

        public Student(double age) => this.age = age;

		public double GetAge()
		{
			return age;
		}
    }

	interface IEmployee
	{
		double GetSalary();
	}

	class Director : IEmployee
	{
		private double salary;

        public Director(double salary) => this.salary = salary;

		public double GetSalary()
		{
			throw new NotImplementedException();
		}
	}

	class Secretary : IEmployee
	{
		private double salary;

		public Secretary(double salary) => this.salary = salary;

		public double GetSalary()
		{
			throw new NotImplementedException();
		}
	}

	class Electrician : IEmployee
	{
		private double salary;

		public Electrician(double salary) => this.salary = salary;

		public double GetSalary()
		{
			throw new NotImplementedException();
		}
	}
}