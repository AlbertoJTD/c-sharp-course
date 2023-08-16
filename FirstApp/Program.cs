using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> people = new Dictionary<string, int>();

			// Add elements
			people.Add("John", 35);
			people.Add("Elena", 39);
			people.Add("Jax", 34);
			people["Cassy"] = 29;

            // Read dictionary
            foreach (KeyValuePair<string, int> kvp in people)
            {
                Console.WriteLine($"Person: ({kvp.Key}, {kvp.Value})");
            }
        }
	}
}