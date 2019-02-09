using System.Globalization;

namespace ReversePolishNotation.Domain.Numbers
{
	public class Number : NumberBase
	{
		public override double Value => double.Parse(Entry, CultureInfo.InvariantCulture);

		public Number(string value)
			: this(double.Parse(value))
		{
		}

		public Number(double value)
			: base(value.ToString(CultureInfo.InvariantCulture))
		{
		}
	}
}
