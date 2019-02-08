namespace ReversePolishNotation.Domain.Operators
{
	public abstract class OperatorBase : Token
	{
		public virtual int Precedence => 1;
		public virtual Associativity Associativity => Associativity.Left;

		protected OperatorBase(string entry)
			: base(entry)
		{
		}

		public abstract double Calculate(double left, double right);
	}
}
