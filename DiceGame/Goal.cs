using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
	public class Goal
	{
		private Func<short[], short> onSummarize;

		public string Name { get; }
		public short Points { get; private set; }
		public bool IsUsed { get; private set; }

		public Goal(string name, Func<short[], short> onSummarize)
		{
			Name = name;
			this.onSummarize = onSummarize;
		}

		public void Achieve(short[] dice)
		{
			Points = this.onSummarize(dice);
			IsUsed = true;
		}
	}
}
