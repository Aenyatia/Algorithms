namespace ReversePolishNotation.Domain.Operators
{
	public class Addition : OperatorBase
	{
		public Addition(string entry)
			: base(entry)
		{
		}

		public override double Calculate(double left, double right)
		{
			return left + right;
		}
	}
}
