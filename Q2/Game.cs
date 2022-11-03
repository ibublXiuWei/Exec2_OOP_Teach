using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	public class Game
	{
		public int[] Dices { get; } //(屬性--唯讀)
		private int pointOfpair;//成對最小點數存放在這--(欄位?)
		/// <summary>
		/// 測試用的建構函數，四個數字必須介於1~6
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <param name="n3"></param>
		/// <param name="n4"></param>
		/// <exception cref="Exception"></exception>
		public Game(int n1,int n2,int n3, int n4) //--Game 的建構函數 
		{
			int[] dices = new int[] {n1,n2,n3,n4};
			Array.Sort(dices); //由小到大 排序

			if (dices[0] == dices[1])
			{
				pointOfpair = dices[0];
			}
			else if (dices[1] == dices[2])
			{
				pointOfpair = dices[1];
			}
			else if (dices[2] == dices[3])
			{
				pointOfpair = dices[2];
			}
			else
			{
				throw new Exception("骰子點數沒有兩個以上相同的");
			}
			Dices = dices;
		}
		public static Game NewGame()
		{
			Game game = null;
			var random=new Random(Guid.NewGuid().GetHashCode());
			while(game==null)
			{
				try
				{
					game = new Game(random.Next(1, 7),
									random.Next(1,7),
									random.Next(1, 7),
									random.Next(1, 7)
														);
				}catch
				{

				}
			}
			return game;
		}
		/// <summary>
		/// 計算點數-扣除最小的兩顆成對點數，將剩下兩顆加總
		/// </summary>
		/// <returns></returns>
		public int GetPoints()
		{
			return Dices.Sum() - pointOfpair * 2;
		}

		public override string ToString() //覆寫的使用還不太確定--這也是一個Method嗎？
		{
			return $"骰子{Dices[0]},{Dices[1]},{Dices[2]},{Dices[3]} 總點數{GetPoints()}";
		}
	}
}
