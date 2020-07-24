using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
	class DiceRoller
	{
		private Random random;

		public DiceRoller(Random random)
		{
			this.random = random;
		}

		public short[] Roll(int n)
		{
			var dice = new short[n];
			for (int i = 0; i < n; i++)
			{
				dice[i] = (short)this.random.Next(1, 7);
			}
			return dice;
		}
	}
}
