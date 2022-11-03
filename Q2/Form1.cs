using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void playTextbox_Click(object sender, EventArgs e)
		{
			Game game;
			game = Game.NewGame();//new Game(1, 3, 5, 1);
			historyTextBox.Text += game.ToString()+"\r\n";
		}
	}
}
