using FluentAssertions;
using Xunit;

namespace Fizzbuzz.Tests
{
	public class FuzzBuzzTests
	{
		[Theory]
		[InlineData(15)]
		[InlineData(30)]
		[InlineData(45)]
		[InlineData(60)]
		[InlineData(75)]
		public void Check_NumberIsDividedBy3And5_PrintFizzBuzz(int value)
		{
			var result = FizzBuzz.Check(value);

			result.Should().BeEquivalentTo("FizzBuzz");
		}

		[Theory]
		[InlineData(3)]
		[InlineData(6)]
		[InlineData(9)]
		[InlineData(12)]
		[InlineData(18)]
		public void Check_NumberIsDividedBy3NotBy5_PrintFizz(int value)
		{
			var result = FizzBuzz.Check(value);

			result.Should().BeEquivalentTo("Fizz");
		}

		[Theory]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(20)]
		[InlineData(25)]
		[InlineData(35)]
		public void Check_NumberIsDividedBy5NotBy3_PrintBuzz(int value)
		{
			var result = FizzBuzz.Check(value);

			result.Should().BeEquivalentTo("Buzz");
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(4)]
		[InlineData(7)]
		[InlineData(8)]
		public void Check_NumberIsNotDividedBy3And5_PrintInput(int value)
		{
			var result = FizzBuzz.Check(value);

			result.Should().BeEquivalentTo(value.ToString());
		}
	}
}
