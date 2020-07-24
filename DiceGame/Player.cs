namespace DiceGame
{
	public class Player
	{
		public string Name { get; }
		public int Points { get; set; }

		public Player(string name)
		{
			Name = name;
		}
	}
}