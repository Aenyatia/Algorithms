namespace ReversePolishNotation.Domain.Operators
{
	public class Multiplication : OperatorBase
	{
		public override int Priority => 2;

		public Multiplication(string entry)
			: base(entry)
		{
		}

		public override double Calculate(double left, double right)
		{
			return left * right;
		}
	}
}
