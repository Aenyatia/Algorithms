using System;
using System.Globalization;

namespace ReversePolishNotation.Domain.Numbers
{
	public class Pi : NumberBase
	{
		public override double Value => double.Parse(Entry);

		public Pi()
			: base(Math.PI.ToString(CultureInfo.InvariantCulture))
		{
		}
	}
}
