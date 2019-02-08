namespace ReversePolishNotation.Domain
{
	public abstract class Token
	{
		public string Entry { get; }

		protected Token(string entry)
		{
			Entry = entry;
		}
	}
}
