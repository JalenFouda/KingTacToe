using System.Windows;

namespace KingTacToe
{
	internal class CheckGameFinished
	{
		public static bool IsTheWinner(ref bool winner)
		{
			//Rows
			if ((GameProps.buttons[0].Content == GameProps.buttons[1].Content) && (GameProps.buttons[1].Content == GameProps.buttons[2].Content) && (string)GameProps.buttons[0].Content != null)
			{ return GameProps.Winner = winner = true;}
			if ((GameProps.buttons[3].Content == GameProps.buttons[4].Content) && (GameProps.buttons[4].Content == GameProps.buttons[5].Content) && (string)GameProps.buttons[3].Content != null)
			{ return GameProps.Winner = winner = true;}
			if ((GameProps.buttons[6].Content == GameProps.buttons[7].Content) && (GameProps.buttons[7].Content == GameProps.buttons[8].Content) && (string)GameProps.buttons[6].Content != null)
			{ return GameProps.Winner = winner = true;}

			//Columns
			if ((GameProps.buttons[0].Content == GameProps.buttons[3].Content) && (GameProps.buttons[3].Content == GameProps.buttons[6].Content) && (string)GameProps.buttons[0].Content != null)
			{ return GameProps.Winner = winner = true;}
			if ((GameProps.buttons[1].Content == GameProps.buttons[4].Content) && (GameProps.buttons[4].Content == GameProps.buttons[7].Content) && (string)GameProps.buttons[1].Content != null)
			{ return GameProps.Winner = winner = true;}
			if ((GameProps.buttons[2].Content == GameProps.buttons[5].Content) && (GameProps.buttons[5].Content == GameProps.buttons[8].Content) && (string)GameProps.buttons[2].Content != null)
			{ return GameProps.Winner = winner = true;}
			//Diagonal
			if ((GameProps.buttons[0].Content == GameProps.buttons[4].Content) && (GameProps.buttons[4].Content == GameProps.buttons[8].Content) && (string)GameProps.buttons[0].Content != null)
			{ return GameProps.Winner = winner = true;}
			if ((GameProps.buttons[6].Content == GameProps.buttons[4].Content) && (GameProps.buttons[4].Content == GameProps.buttons[2].Content) && (string)GameProps.buttons[6].Content != null)
			{ return GameProps.Winner = winner = true;}

			else { return GameProps.Winner = winner = false;}

		}
		public static bool IsTieGame(bool winner,ref int round)
		{
			if (round == 9 && (winner == false))
			{
				return true;
			}
			else { return false; }
		}

		public static void GameDone(MainWindow king, int index, ref int round, ref int player, ref bool winner) 
		{
			GameProps.Index = index;
			GameProps.Round = round;
			GameProps.Player = player;
			
			GameProps.Winner = winner;
			if (GameProps.Winner.Equals(true))
			{
				if ((string)GameProps.buttons[GameProps.Index].Content == "X")
				{
					MessageBox.Show("Player X has won.");
					GameProps.P1++;
					king.Player1.Content = "P1 - X: " + GameProps.P1;
					ClickEventsLogic.NewGame(king, ref player, ref round, ref winner);
				}
				else if ((string)GameProps.buttons[GameProps.Index].Content == "O")
				{
					MessageBox.Show("Player O has won.");
					GameProps.P2++;
					king.Player2.Content = "P2 - O: " + GameProps.P2;
					ClickEventsLogic.NewGame(king, ref player, ref round, ref winner);
				}
			}
			else if (IsTieGame(GameProps.Winner, ref GameProps.Round) == true)
			{
				MessageBox.Show("Tie Game.");
				GameProps.TieGame++;
				king.Draw.Content = "Draw: " + GameProps.TieGame;
				ClickEventsLogic.NewGame(king, ref player, ref round, ref winner);
			}
		}
	}
}
