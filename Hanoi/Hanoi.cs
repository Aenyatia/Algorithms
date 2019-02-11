using System;

namespace Hanoi
{
	public class Hanoi
	{
		/*
		 * n == 4
		 *
		 * 1
		 * 2
		 * 3
		 * 4
		 * A B C
		 *
		 * Hanoi(4, from(a), temp(b), to(c))
		 *		=> Hanoi(3, from(a), temp(c), to(b))
		 *		=> a -> c
		 *		=> Hanoi(3, from(b), temp(a), to(c))
		 */

		public static void Resolve(int n, char a, char b, char c)
		{
			if (n == 1)
			{
				Console.WriteLine($"Disc: {a} -> {c}");
				return;
			}

			Resolve(n - 1, a, c, b);
			Console.WriteLine($"Disc: {a} -> {c}");
			Resolve(n - 1, b, a, c);
		}
	}
}
