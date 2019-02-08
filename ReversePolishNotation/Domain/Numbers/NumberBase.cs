namespace ReversePolishNotation.Domain.Numbers
{
	public abstract class NumberBase : Token
	{
		public abstract double Value { get; }

		protected NumberBase(string entry)
			: base(entry)
		{
		}
	}
}
