namespace ReversePolishNotation.Domain.Functions
{
	public abstract class FunctionBase : Token
	{
		protected FunctionBase(string function)
			: base(function)
		{
		}

		public abstract double Calculate(double value);
	}
}
