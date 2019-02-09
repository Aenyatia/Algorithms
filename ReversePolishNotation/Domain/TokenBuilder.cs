using ReversePolishNotation.Domain.Brackets;
using ReversePolishNotation.Domain.Functions;
using ReversePolishNotation.Domain.Numbers;
using ReversePolishNotation.Domain.Operators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

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
			RegisterToken<Power>(x => x == "^");

			RegisterToken<Number>(x =>
			{
				string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
				string reqexSeparator = Regex.Escape(separator);
				string[] patterns = new string[] {
					string.Format(@"^(\d+({0}\d*)?)$",reqexSeparator), //dec/float
					@"^0[xX][0-9a-fA-F]+$" // hex
				};
				return patterns.Any(p => Regex.Match(x, p).Success);
			});
			RegisterToken<Pi>(x => x == "pi");

			RegisterToken<Sqrt>(x => x == "sqrt");
			RegisterToken<Sinus>(x => x == "sin");
			RegisterToken<Cosinus>(x => x == "cos");

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
