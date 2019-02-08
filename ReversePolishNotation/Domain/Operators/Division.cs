namespace ReversePolishNotation.Domain.Operators
{
	public class Division : OperatorBase
	{
		public Division(string entry)
			: base(entry)
		{
		}

		public override double Calculate(double left, double right)
		{
			return left / right;
		}
	}
}
