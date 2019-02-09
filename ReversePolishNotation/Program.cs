using ReversePolishNotation.Domain;
using System;
using System.Globalization;

namespace ReversePolishNotation
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var engine = new RpnEngine(new TokenBuilder());
			var a = double.Parse("0,8414709848", CultureInfo.InvariantCulture);
			//var result = engine.Calculate("2+2*((6-3)*2)");
			var result = engine.Calculate("(sin(0)+cos(0)+2)*2-sqrt(4)*2-cos(0)");

			Console.WriteLine(result);
		}
	}
}
