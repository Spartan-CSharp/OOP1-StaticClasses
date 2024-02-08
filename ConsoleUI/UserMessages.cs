using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal static class UserMessages
	{
		internal static void GreetUser(string firstName)
		{
			Console.Clear();
			Console.WriteLine("Welcome to our Calculator App!");

			int hourofday = DateTime.Now.Hour;

			if ( hourofday > 2 && hourofday < 12 )
			{
				Console.WriteLine($"Good morning {firstName}.");
			}
			else if ( hourofday > 12 && hourofday < 18 )
			{
				Console.WriteLine($"Good afternoon {firstName}.");
			}
			else
			{
				Console.WriteLine($"Good evening {firstName}.");
			}

			Console.WriteLine();
		}

		internal static void DisplayResult(string message)
		{
			Console.WriteLine();
			Console.WriteLine(message);
			Console.WriteLine();
			Console.WriteLine("Thank you for using our Calculator App!");
		}

		internal static void DisplayErrorMessage(string message)
		{
			Console.WriteLine();
			Console.WriteLine(message);
			Console.WriteLine();
			Console.WriteLine("Thank you for using our Calculator App!");
		}
	}
}
