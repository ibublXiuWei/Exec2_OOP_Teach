using Exec2_OOP;
using System.Globalization;

namespace _1A2B_GameTestProject1
{
	public class Tests
	{
		public void ShouldBeEual(string answer,string input,string expected)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);
			Assert.AreEqual(expected, actual);

		}
		[TestCase("1234","5678")]
		[TestCase("1234","9056")]
		public void PLay_0A0B(string answer,string input)
		{
			Game game = new Game(answer);
			string actual=game.Play(input);
			string expected = "0A0B";
			Assert.AreEqual(expected,actual);
		}

		[TestCase("1234", "5671")]
		public void PLay_0A1B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);
			string expected = "0A1B";
			Assert.AreEqual(expected, actual);
		}

		[TestCase("1234", "5231")]
		public void PLay_2A1B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);
			string expected = "2A1B";
			Assert.AreEqual(expected, actual);
		}

		[TestCase("1234", "1243")]
		public void PLay_2A2B(string answer, string input)
		{
			ShouldBeEual(answer, input, "2A2B");
		}
	}
}