using System;

namespace ReversePolishNotation.Domain.Functions
{
	public class Sinus : FunctionBase
	{
		public Sinus(string function)
			: base(function)
		{
		}

		public override double Calculate(double value)
		{
			return Math.Sin(value);
		}
	}
}
