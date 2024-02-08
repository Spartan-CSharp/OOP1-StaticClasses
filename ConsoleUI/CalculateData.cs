using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal static class CalculateData
	{
		internal static double Operate(double x, double y, char opp)
		{
			double output = 0.0;

			switch ( opp )
			{
				case '+':
					output = Add(x, y);
					break;
				case '-':
					output = Subtract(x, y);
					break;
				case '*':
					output = Multiply(x, y);
					break;
				case '/':
					output = Divide(x, y);
					break;
				default:
					UserMessages.DisplayErrorMessage("That is not a valid operation.");
					break;
			}

			return output;
		}

		private static double Add(double x, double y)
		{
			double output = x + y;
			return output;
		}

		private static double Subtract(double x, double y)
		{
			double output = x - y;
			return output;
		}

		private static double Multiply(double x, double y)
		{
			double output = x * y;
			return output;
		}

		private static double Divide(double x, double y)
		{
			double output = 0.0;

			if ( y != 0.0 )
			{
				output = x / y;
			}
			else
			{
				UserMessages.DisplayErrorMessage("We cannot divide by zero.");
			}

			return output;
		}
	}
}
