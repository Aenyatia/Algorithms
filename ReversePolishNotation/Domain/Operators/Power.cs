using System;

namespace ReversePolishNotation.Domain.Operators
{
	public class Power : OperatorBase
	{
		public override int Priority => 3;
		public override Associativity Associativity => Associativity.Right;

		public Power(string entry)
			: base(entry)
		{
		}

		public override double Calculate(double left, double right)
		{
			return Math.Pow(left, right);
		}
	}
}
