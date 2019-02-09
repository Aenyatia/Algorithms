using System;
using System.Globalization;

namespace ReversePolishNotation.Domain.Numbers
{
	public class Pi : NumberBase
	{
		public override double Value => double.Parse(Entry, CultureInfo.InvariantCulture);

		public Pi()
			: base(Math.PI.ToString(CultureInfo.InvariantCulture))
		{
		}
	}
}
