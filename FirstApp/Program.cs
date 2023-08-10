using System;
using System.Runtime.ConstrainedExecution;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader file = null;

			try
			{
				string line;

				int count = 0;
				string path = @"test_file.txt";

				file = new StreamReader(path);

				while ((line = file.ReadLine()) != null) // While there is lines to read
				{
					Console.WriteLine(line);
					count++;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error reading file");
			}
			finally
			{
				if (file != null) file.Close();
				Console.WriteLine("Closed connection");
			}
		}
	}
}