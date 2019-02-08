namespace ReversePolishNotation.Domain.Operators
{
	public class Subtraction : OperatorBase
	{
		public Subtraction(string entry)
			: base(entry)
		{
		}

		public override double Calculate(double left, double right)
		{
			return left - right;
		}
	}
}
