using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
	public static class FiveDiceBuilder
	{
		public static IEnumerable<Goal> Build()
		{
			yield return new Goal("1'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 1)
					{
						result++;
					}
				}
				return result;
			});
			yield return new Goal("2'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 2)
					{
						result += 2;
					}
				}
				return result;
			});
			yield return new Goal("3'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 3)
					{
						result += 3;
					}
				}
				return result;
			});
			yield return new Goal("4'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 4)
					{
						result += 4;
					}
				}
				return result;
			});
			yield return new Goal("5'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 5)
					{
						result += 5;
					}
				}
				return result;
			});
			yield return new Goal("6'ere", dice =>
			{
				short result = 0;
				foreach (var d in dice)
				{
					if (d == 6)
					{
						result += 6;
					}
				}
				return result;
			});
			yield return new Goal("1 par", dice =>
			{
				short result = 0;
				for (int i = 0; i < dice.Length; i++)
				{
					for (int j = i + 1; j < dice.Length; j++)
					{
						if (dice[i] == dice[j])
						{
							result = (short)(dice[i] + dice[j]); 
						}
					}
				}
				return result;
			});
			yield return new Goal("2 par", dice =>
			{
				short result = 0;
				for (int i = 0; i < dice.Length; i++)
				{
					for (int j = i + 1; j < dice.Length; j++)
					{
						if (dice[i] == dice[j] && result != dice[i] + dice[j])
						{
							result = (short)(result + dice[i] + dice[j]);
							i = j;
						}
					}
				}
				return result;

			});
			yield return new Goal("3 ens", dice =>
			{
				short result = 0;
				for (int i = 1; i <= 6; i++)
				{
					int count = 0;
					foreach (var d in dice)
					{
						if (d == i)
						{
							count++;
						}
					}
					if (count == 3)
					{
						result = (short)(3 * i);
					}
				}
				return result;
			});
			yield return new Goal("4 ens", dice =>
			{
				short result = 0;
				for (int i = 1; i <= 6; i++)
				{
					int count = 0;
					foreach (var d in dice)
					{
						if (d == i)
						{
							count++;
						}
					}
					if (count == 4)
					{
						result = (short)(4 * i);
					}
				}
				return result;
			});
			yield return new Goal("Lille straight", dice =>
			{
				short result = 0;
				for (short i = 1; i <= 5; i++)
				{
					if (dice.Contains(i))
					{
						result += i;
					}
				}
				return result;
			});
			yield return new Goal("Stor straight", dice =>
			{
				short result = 0;
				for (short i = 2; i <= 6; i++)
				{
					if (dice.Contains(i))
					{
						result += i;
					}
				}
				return result;
			});
			yield return new Goal("Hus", dice =>
			{
				short result = 0;
				for (int i = 1; i <= 6; i++)
				{
					var matches = 0;
					foreach (var d in dice)
					{
						if (i == d)
						{
							matches++;
						}
					}
					if (matches == 2)
					{
						result += (short)(2 * i);
					}
					else if (matches == 3)
					{
						result += (short)(3 * i);
					}
				}
				return result;
			});

			yield return new Goal("Chance", dice =>
			{
				return (short)dice.Sum(d => d);
			});
			yield return new Goal("Yatzy", dice =>
			{
				var result = 0;
				var occurences = 1;
				for (int i = 0; i < dice.Length - 1; i++)
				{
					if (dice[i] == dice[i + 1])
					{
						occurences++;
					}
				}
				if (occurences == 5)
				{
					result = 50;
				}
				return (short)result;
			});
			//yield return new Goal("", dice =>
			//{

			//});
		}
	}
}
