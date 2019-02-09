using System;

namespace ReversePolishNotation.Domain.Functions
{
	public class Cosinus : FunctionBase
	{
		public Cosinus(string function)
			: base(function)
		{
		}

		public override double Calculate(double value)
		{
			return Math.Cos(value);
		}
	}
}
