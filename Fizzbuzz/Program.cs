using System;

namespace Fizzbuzz
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			for (var i = 1; i <= 100; i++)
				Console.WriteLine($"i = {i} -> {FizzBuzz.Check(i)}");
		}
	}
}
