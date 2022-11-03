using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP
{
	public partial class Form1 : Form
	{
		private Game game; //這是甚麼意思
		public Form1()
		{
			InitializeComponent();
			answerlabel.Text = string.Empty;
			answerlabel.Visible=false;
		}

		private void NewGamebutton_Click(object sender, EventArgs e)
		{
			game = Game.newGame(); //new Game("1234");
			answerlabel.Text = game.Answer; //為甚麼可以直接這樣用
			GuesstextBox.MaxLength = 4;		
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			string input = GuesstextBox.Text;
			//to do驗證長度是4的不重複數字
			string result = game.Play(input); //這邊game 到底是甚麼
			if(result=="4A0B")
			{
				MessageBox.Show("您答對了");
				return;
			}

			//若答錯，加到下面呈現
			historyTextbox.Text += result+"\r\n";

		}
	}
}
