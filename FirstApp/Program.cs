using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ManageFiles manageFiles = new ManageFiles();
			manageFiles.Message();
		}
	}

	class ManageFiles
	{
		StreamReader file = null;
		int counter = 0;
		string line;

		public ManageFiles()
		{
			file = new StreamReader(@"test_file.txt");

			while ((line = file.ReadLine()) != null)
			{
				Console.WriteLine(line);
				counter++;
			}
		}

		// Destructor
		~ManageFiles()
		{
			file.Close();
		}

		public void Message()
		{
			Console.WriteLine($"Number of lines: {counter}");
		}
	}
}