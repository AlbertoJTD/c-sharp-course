using System;
namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			TrafficNotices trafficNotice = new TrafficNotices(); // default constructor
			trafficNotice.ShowNotice();

			TrafficNotices trafficNotice2 = new TrafficNotices("Police", "exceeding the maximum speed limit", "08/13/2023");
            Console.WriteLine(trafficNotice2.GetDate());
            trafficNotice2.ShowNotice();
		}
	}
}