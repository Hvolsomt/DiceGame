using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Xunit.Sdk;

namespace DiceGame.Test
{
	[TestClass]
	public class FiveDiceBuilderTest
	{
		[TestMethod]
		public void ENere_GivenArrayOfDiceContainingSeveralDiceOfOne_ReturnsSumOfOnes()
		{
			// Arrange
			var input = new short[] { 1, 1, 1, 2, 3 };
			var expected = 3;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("1'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void TOere_GivenArrayOfDiceContainingSeveralDiceOfTwo_ReturnsSumOfTwos()
		{
			// Arrange
			var input = new short[] { 1, 1, 2, 2, 3 };
			var expected = 4;
			var goals = FiveDiceBuilder.Build();
			var goal = goals.First(g => g.Name.ToUpper().Equals("2'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TREere_GivenArrayOfDiceContainingSeveralDiceOfThree_ReturnsSumOfThrees()
		{
			// Arrange
			var input = new short[] { 1, 3, 3, 2, 3 };
			var expected = 9;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("3'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void FIREre_GivenArrayOfDiceContainingSeveralDiceOfFour_ReturnsSumOfFours()
		{
			// Arrange
			var input = new short[] { 4, 1, 4, 2, 3 };
			var expected = 8;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("4'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void FEMmere_GivenArrayOfDiceContainingSeveralDiceOfFive_ReturnsSumOfFives()
		{
			// Arrange
			var input = new short[] { 1, 5, 5, 2, 5 };
			var expected = 15;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("5'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void SEKSere_GivenArrayOfDiceContainingSeveralDiceOfSix_ReturnsSumOfSixes()
		{
			// Arrange
			var input = new short[] { 1, 6, 1, 6, 3 };
			var expected = 12;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("6'ERE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Etpar_GivenArrayOfDiceContainingOnePair_ReturnsSumOfPair()
		{
			// Arrange
			var input = new short[] { 2, 5, 2, 3, 5 };
			var expected = 10;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("1 PAR"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Topar_GivenArrayOfDiceContainingTwoPairs_ReturnsSumOfPairs()
		{
			// Arrange
			var input = new short[] { 2, 5, 2, 5, 5 };
			var expected = 14;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("2 PAR"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Trelige_GivenArrayOfDiceContainingThreeOfAKind_ReturnsSumOfThreeOfAKind()
		{
			// Arrange
			var input = new short[] { 2, 5, 2, 5, 5 };
			var expected = 15;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("3 ENS"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Firelige_GivenArrayOfDiceContainingFourOfAKind_ReturnsSumOfFourOfAKind()
		{
			// Arrange
			var input = new short[] { 5, 5, 2, 5, 5 };
			var expected = 20;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("4 ENS"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void LilleStraight_GivenArrayOfDiceContainingOneToFive_ReturnsSumOfOneToFive()
		{
			// Arrange
			var input = new short[] { 3, 2, 1, 5, 4 };
			var expected = 15;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("LILLE STRAIGHT"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void StorStraight_GivenArrayOfDiceContainingTwoToSix_ReturnsSumOfTwoToSix()
		{
			// Arrange
			var input = new short[] { 3, 2, 6, 5, 4 };
			var expected = 20;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("STOR STRAIGHT"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Hus_GivenArrayOfDiceContainingThreeOfAKindAndOnePair_ReturnsSumOfThreeOfAKindAndOnePair()
		{
			// Arrange
			var input = new short[] { 5, 6, 6, 5, 6 };
			var expected = 28;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("HUS"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Hus_GivenArrayOfDiceContainingFiveDiceOfAKind_ReturnsZero()
		{
			// Arrange
			var input = new short[] { 5, 5, 5, 5, 5 };
			var expected = 0;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("HUS"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Chance_GivenArrayOfDice_ReturnsSumOfDice()
		{
			// Arrange
			var input = new short[] { 2, 3, 6, 3, 5 };
			var expected = 19;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("CHANCE"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Yatzy_GivenArrayOfDiceContainingDiceOfEqualValue_ReturnsFifty()
		{
			// Arrange
			var input = new short[] { 6, 6, 6, 6, 6 };
			var expected = 50;
			var goal = FiveDiceBuilder.Build().First(g => g.Name.ToUpper().Equals("YATZY"));

			// Act
			goal.Achieve(input);
			var actual = goal.Points;

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
