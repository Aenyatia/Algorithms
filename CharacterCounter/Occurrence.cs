namespace CharacterCounter
{
	public class Occurrence
	{
		public char Character { get; }
		public int Times { get; private set; }

		public Occurrence(char character)
		{
			Character = character;
			Times = 1;
		}

		public void AddOccurrence()
			=> Times++;
	}
}
