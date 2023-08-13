using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Airplane airplane = new Airplane();
			Car car = new Car();

			airplane.StartEngine();
			airplane.Drive();
			airplane.StopEngine();

			car.StartEngine();
			car.Drive();
			car.StopEngine();
		}
	}

	class Vehicle
	{
		public void StartEngine()
		{
			Console.WriteLine("Starting engine...");
		}

		public void StopEngine()
		{
			Console.WriteLine("Stopping engine...");
		}

		public virtual void Drive()
		{
			Console.WriteLine("Vehicle to drive...");
		}
	}

	class Airplane : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("Piloting an Airplane.");
		}
	}

	class Car : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("Driving a Car.");
		}
	}
}