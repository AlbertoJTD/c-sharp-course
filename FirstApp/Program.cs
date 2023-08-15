using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			WarehouseObjects<Employee> files = new WarehouseObjects<Employee>(4);

			// ------------------
			files.AddElement(new Employee(2000));
			files.AddElement(new Employee(1000));
			files.AddElement(new Employee(500));
			files.AddElement(new Employee(100));

			Employee person = files.GetElement(2);
            Console.WriteLine(person.GetSalary());


			WarehouseObjects<DateTime> dates = new WarehouseObjects<DateTime>(1);
			dates.AddElement(new DateTime());
            Console.WriteLine(dates.GetElement(0));
        }
	}

	class WarehouseObjects<T>
	{
		private T[] data;
		private int counter = 0;

        public WarehouseObjects(int numberElements)
        {
			data = new T[numberElements];
        }

		public void AddElement(T obj)
		{
			data[counter] = obj;
			counter++;
		}

		public T GetElement(int position)
		{
			return data[position];
		}
    }

	class Employee
	{
		private double salary;

        public Employee(double salary)
        {
			this.salary = salary;
        }

		public double GetSalary()
		{
			return salary;
		}
    }
}