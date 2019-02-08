namespace Fizzbuzz
{
	public static class FizzBuzz
	{
		private const string Fizz = "Fizz";
		private const string Buzz = "Buzz";

		public static string Check(int number)
		{
			if (number % 3 == 0 && number % 5 == 0)
				return Fizz + Buzz;

			if (number % 3 == 0)
				return Fizz;

			if (number % 5 == 0)
				return Buzz;

			return number.ToString();
		}
	}
}
