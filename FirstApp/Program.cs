using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string phrase = "My name is John and my phone number is (+34)123-45-67 and my zip code is 29679";
			// Example 1
			//string pattern = "[J]";

			// Example 2
			string pattern = @"\d{3}-\d{2}-\d{2}";

			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(phrase);

			/* Example 1
			if (matches.Count > 0) Console.WriteLine("J was found");
			else Console.WriteLine("J was not found"); */

			// Example 2
			if (matches.Count > 0) Console.WriteLine("The number sequence was found");
			else Console.WriteLine("No number sequence found");
        }
	}
}