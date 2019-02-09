using System.Collections.Generic;

namespace CharacterCounter
{
	public static class CharacterCounter
	{
		public static Dictionary<char, int> Calculate(string value)
		{
			var list = new Dictionary<char, int>();

			foreach (var character in value)
				if (list.ContainsKey(character))
					list[character]++;
				else
					list.Add(character, 1);

			return list;
		}
	}
}
