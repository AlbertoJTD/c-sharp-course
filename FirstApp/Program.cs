using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
            DoSomething();
        }

		static void DoSomething()
		{
			Coordinate pointA = new Coordinate();
			Coordinate pointB = new Coordinate(10, 2);
		}
	}
}