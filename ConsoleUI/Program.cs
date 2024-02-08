using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string firstname = RequestData.GetAString("What is your first name: ");

			UserMessages.GreetUser(firstname);

			double firstnumber = RequestData.GetADouble("Enter your first number: ");
			double secondnumber = RequestData.GetADouble("Enter your second number: ");
			char operation = RequestData.GetOperation("Enter the operation to perform (+, -, *, /): ");

			double result = CalculateData.Operate(firstnumber, secondnumber, operation);

			UserMessages.DisplayResult($"The result of {firstnumber} {operation} {secondnumber} is {result}.");

			_ = Console.ReadLine();
		}
	}
}
