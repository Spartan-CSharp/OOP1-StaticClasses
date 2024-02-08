using System;

namespace ConsoleUI
{
	internal static class RequestData
	{
		internal static string GetAString(string message)
		{
			Console.Write(message);
			string output = Console.ReadLine();
			return output;
		}

		internal static double GetADouble(string message)
		{
			double output;
			bool isvaliddouble;

			do
			{
				Console.Write(message);
				string numbertext = Console.ReadLine();
				isvaliddouble = double.TryParse(numbertext, out output);
				if ( !isvaliddouble )
				{
					Console.WriteLine("That is not a valid number. Please try again.");
				}
			} while ( !isvaliddouble );

			return output;
		}

		internal static char GetOperation(string message)
		{
			char output;
			bool isvalidoperation = false;

			do
			{
				Console.Write(message);
				string input = Console.ReadLine();
				output = input[0];
				if ( output != '+' && output != '-' && output != '*' && output != '/' )
				{
					Console.WriteLine("That is not a valid operation. Please try again.");
				}
				else
				{
					isvalidoperation = true;
				}
			} while ( !isvalidoperation );

			return output;
		}
	}
}
