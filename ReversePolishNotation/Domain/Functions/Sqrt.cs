using System;

namespace ReversePolishNotation.Domain.Functions
{
	public class Sqrt : FunctionBase
	{
		public Sqrt(string function)
			: base(function)
		{
		}

		public override double Calculate(double value)
		{
			return Math.Sqrt(value);
		}
	}
}
