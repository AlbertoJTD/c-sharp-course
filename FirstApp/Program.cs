using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Math; // import all methods of the Math class

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Implicit array
			var data = new[] {"John", "Wick"};
			var data2 = new[] { 15, 20, 90.8, 0.99};

			// Array of objects
			Employee Ana = new Employee("Ana", 54);
			Employee[] employees = new Employee[2];
			employees[0] = new Employee("John", 39);
			employees[1] = Ana;

			// Array of anonymous types or classes
			var data3 = new[]
			{
				new {Name ="Juan", Age = 20},
				new {Name = "Wick", Age = 21},
				new {Name = "Winston", Age = 22},
			};


			for (int i = 0; i < data2.Length; i++)
			{
				Console.WriteLine(data2[i]);
            }

			for (int i = 0; i < employees.Length; i++)
			{
				Console.WriteLine($"Name: {employees[i].getName()}, Age: {employees[i].getAge()}");
			}
		}
	}

	class Employee
	{
		private string name;
		private int age;

        public Employee(string name, int age)
        {
			this.name = name;
			this.age = age;
		}

		public string getName()
		{
			return this.name;
		}

		public int getAge()
		{
			return this.age;
		}
    }
}