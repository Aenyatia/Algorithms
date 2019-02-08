using ReversePolishNotation.Domain.Brackets;
using ReversePolishNotation.Domain.Functions;
using ReversePolishNotation.Domain.Numbers;
using ReversePolishNotation.Domain.Operators;
using System;
using System.Collections.Generic;

namespace ReversePolishNotation.Domain
{
	public class TokenBuilder
	{
		private readonly Dictionary<Func<string, bool>, Type> _registeredTokens = new Dictionary<Func<string, bool>, Type>();

		public TokenBuilder()
		{
			RegisterToken<Addition>(x => x == "+");
			RegisterToken<Subtraction>(x => x == "-");
			RegisterToken<Multiplication>(x => x == "*");
			RegisterToken<Division>(x => x == "/");

			RegisterToken<Pi>(x => x == "pi");

			RegisterToken<Sqrt>(x => x == "sqrt");

			RegisterToken<LeftBracket>(x => x == "(");
			RegisterToken<RightBracket>(x => x == ")");
		}

		public Token GetToken(string arg)
		{
			foreach (var kvp in _registeredTokens)
			{
				if (kvp.Key(arg))
				{
					return (Token)Activator.CreateInstance(kvp.Value, arg);
				}
			}

			return null;
		}

		public void RegisterToken<T>(Func<string, bool> func) where T : Token
		{
			if (_registeredTokens.ContainsKey(func))
				return;

			_registeredTokens.Add(func, typeof(T));
		}
	}
}
