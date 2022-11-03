using Q2;
using System.Security.AccessControl;

namespace DicesGame_TestProject1
{
	public class Tests
	{
		[TestCase(1,3,2,1,5)]
		public void ShouldBeEqual(int n1,int n2,int n3,int n4, int expected)
		{
			var game = new Game(n1, n2, n3, n4);
			int actual = game.GetPoints();
			Assert.AreEqual(expected,actual);
		}
		[TestCase(1, 3, 1, 1, 4)]
		public void GetPoint_three_same_Test1(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}

		[TestCase(1, 1, 1, 1, 2)]
		public void GetPoint_four_same_Test1(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}

		[TestCase(5, 5, 1, 1, 10)]
		public void GetPoint_pair_Test1(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}
	}
}