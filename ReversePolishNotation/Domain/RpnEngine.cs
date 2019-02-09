using ReversePolishNotation.Domain.Brackets;
using ReversePolishNotation.Domain.Functions;
using ReversePolishNotation.Domain.Numbers;
using ReversePolishNotation.Domain.Operators;
using System;
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
			=> ProcessQueue(GetPostfix(expression));

		private Queue<Token> GetPostfix(string expression)
		{
			var queue = new Queue<Token>();
			var stack = new Stack<Token>();
			var index = 0;

			while (expression.Length > 0)
			{
				var token = GetNextToken(expression, ref index);
				if (token == null)
					break;

				switch (token)
				{
					case NumberBase _:
						queue.Enqueue(token);
						break;

					case FunctionBase _:
						stack.Push(token);
						break;

					case LeftBracket _:
						stack.Push(token);
						break;

					case RightBracket rb:
						while (!(stack.Peek() is LeftBracket))
							queue.Enqueue(stack.Pop());
						stack.Pop();
						break;

					case OperatorBase o:
						while (stack.Count != 0 && stack.Peek() is FunctionBase)
							queue.Enqueue(stack.Pop());

						while (stack.Count != 0 && stack.Peek() is OperatorBase stackOperator)
						{
							if (o.Associativity == Associativity.Left && o.Priority <= stackOperator.Priority ||
								o.Associativity == Associativity.Right && o.Priority < stackOperator.Priority)
								queue.Enqueue(stack.Pop());
							else
								break;
						}
						stack.Push(token);
						break;

					default:
						throw new InvalidOperationException("Unknow case.");
				}
			}

			while (stack.Count > 0)
				queue.Enqueue(stack.Pop());

			return queue;
		}

		private static double ProcessQueue(Queue<Token> queue)
		{
			var stack = new Stack<Token>();

			while (queue.Count > 0)
			{
				var token = queue.Dequeue();

				switch (token)
				{
					case NumberBase n:
						stack.Push(n);
						break;

					case OperatorBase o:
						var right = (NumberBase)stack.Pop();
						var left = (NumberBase)stack.Pop();
						var operationResult = o.Calculate(left.Value, right.Value);
						stack.Push(new Number(operationResult));
						break;

					case FunctionBase f:
						var arg = (NumberBase)stack.Pop();
						var functionResult = f.Calculate(arg.Value);
						stack.Push(new Number(functionResult));
						break;

					default:
						throw new InvalidOperationException($"Unknow case.");
				}
			}

			var result = (NumberBase)stack.Pop();

			if (stack.Count != 0)
				throw new InvalidOperationException("Invalid expression.");

			return result.Value;
		}

		private Token GetNextToken(string expression, ref int index)
		{
			var input = expression.Substring(index);
			var count = 0;

			while (count++ < input.Length)
			{
				var tokenCandidate = input.Substring(0, count);
				var token = _tokenBuilder.GetToken(tokenCandidate);

				if (token == null) continue;

				index += count;
				return token;
			}

			return null;
		}
	}
}
