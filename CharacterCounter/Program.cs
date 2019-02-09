using System;

namespace CharacterCounter
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var result = CharacterCounter.Calculate("eVjMj4TsENU hGFS1ESZkQ HIbSGZWkFd0nA8rk" +
													"W1V2tJQWuUWg dzNUgqPVEuCmUud gWhT93p6hXD3ALrOpnvAVLNj0KDmtAVg34K");
			foreach (var (key, value) in result)
				Console.WriteLine($"character: {key}, times: {value}");
		}
	}
}
