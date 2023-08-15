using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			WarehouseObjects files = new WarehouseObjects(4);
			/*
			files.AddElement("John");
			files.AddElement("Wick");
			files.AddElement("Jax");
			files.AddElement("Trevor");
			string person = (string)files.GetElement(2); // A casting is necessary
			*/

			// ------------------
			files.AddElement(new Employee(2000));
			files.AddElement(new Employee(1000));
			files.AddElement(new Employee(500));
			files.AddElement(new Employee(100));

			// Error: System.InvalidCastException
			// Cannot convert from Employee type to string type
			// Throws a runtime error
			//string person = (string)files.GetElement(2);

			Employee person = (Employee)files.GetElement(2);
		}
	}

	class WarehouseObjects
	{
		private Object[] data;
		private int counter = 0;

        public WarehouseObjects(int numberElements)
        {
			data = new Object[numberElements];
        }

		public void AddElement(Object obj)
		{
			data[counter] = obj;
			counter++;
		}

		public Object GetElement(int position)
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