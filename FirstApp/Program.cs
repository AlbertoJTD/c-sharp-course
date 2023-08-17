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


			// Example 3
			string phrase2 = "My name is John and my phone number is (+34)123-45-67, (+44)123-45-67  and my zip code is 29679";
			string pattern2 = @"\+34|\+44"; // Find +34 or +44

			Regex regex2 = new Regex(pattern2);
			MatchCollection matches2 = regex2.Matches(phrase2);

			if (matches2.Count > 0) Console.WriteLine("The sequence +34 or +44 was found");
			else Console.WriteLine("No sequence found");


			// Example 4
			string phrase3 = "Visit http://www.apple.com";
			string pattern3 = "https?://(www.)?apple.com"; // ? -> Zero or one time

			Regex regex3 = new Regex(pattern3);
			MatchCollection matches3 = regex3.Matches(phrase3);

			if (matches3.Count > 0) Console.WriteLine("Page found");
			else Console.WriteLine("Page not found");
		}
	}
}