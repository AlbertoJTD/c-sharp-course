using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car(); // Create a new object using the constructor
            Console.WriteLine(car.getInfoCar());

			Car car2 = new Car(3000, 1400); // Create a new object using the constructor
			Console.WriteLine(car2.getInfoCar());
		}
	}

	class Car
	{
		// Constructor
		// Constructor Overloading
		public Car() // Provide an initial state for all created objects
		{
			wheels = 4;
			height = 2300.5;
			width = 1200;
		}

		public Car(double height, double width)
		{
			this.wheels = 4;
			this.height = height;
			this.width = width;
		}

		// Properties
		private int wheels;
		private double height;
		private double width;
		private bool airConditioner;
		private string color;

		// Getter -> Get info
		public string getInfoCar()
		{
			return $"--- Info car ---\nWheels: 4\nHeight: {height}\nWidth: {width}";
		}
    }
}