using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_OOP
{
	public class Game
	{/// <summary>
	/// 本次遊戲的答案
	/// </summary>
		public string Answer { get; } //答案的_屬性_唯讀

		public Game(string answer) //建構子是可以寫死的
		{
			this.Answer = answer; //注意this 的使用時間
		}
		public static Game newGame() //靜態的_給windowform呼叫 //呼叫newGame()傳回一個Game的物件
		{
			//取4個亂數(0~9)
			string answer = GenerateRandomNumber();

			//建立 game
			return new Game(answer); /*  這邊我有點看不懂  */
		}

		private static string GenerateRandomNumber()
		{
			string answer=string.Empty;
			var random=new Random(Guid.NewGuid().GetHashCode());

			//用亂數取4個不重複數
			while(answer.Length < 4)
			{
				string digit=random.Next(0,10).ToString(); 
				if(answer.Contains(digit)==false)
				{
					answer += digit;
				}
			}
			return answer;
		}

		public string Play(string input) //method
		{
			//to go input 是長度為4

			int countA = 0; int countB = 0; //本次猜對，總和不超過4
			for (int index = 0; index < input.Length; index++)
			{
				if (input[index] == Answer[index])
				{
					countA++;
				}
				else if(Answer.Contains(input[index].ToString()))//若值對位置錯B加一
				{
					countB++;
				}
			}
			if (countA + countB > 4) throw new Exception(message:"A+B不超過4，,程式有誤");

			return $"{countA}A{countB}B";
		}
	}
}
