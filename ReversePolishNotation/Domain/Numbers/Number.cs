using System.Globalization;

namespace ReversePolishNotation.Domain.Numbers
{
	public class Number : NumberBase
	{
		public override double Value => double.Parse(Entry);

		public Number(double value)
			: base(value.ToString(CultureInfo.InvariantCulture))
		{
		}
	}
}
