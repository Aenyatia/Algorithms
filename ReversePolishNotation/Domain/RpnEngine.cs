using System.Collections.Generic;

namespace ReversePolishNotation.Domain
{
	public class RpnEngine
	{
		private readonly TokenBuilder _tokenBuilder;

		public RpnEngine(TokenBuilder tokenBuilder)
		{
			_tokenBuilder = tokenBuilder;
		}

		public double Calculate(string expression)
		{
			var postfix = GetPostfix(expression);
			return Process(postfix);
		}

		private Queue<Token> GetPostfix(string input)
		{
			var queue = new Queue<Token>();
			var stack = new Stack<Token>();

			while (input.Length > 0)
			{
				
			}
		}

		private double Process(Queue<Token> queue)
		{
			return 0.0;
		}

		private Token GetNextToken()
		{

		}
	}
}
