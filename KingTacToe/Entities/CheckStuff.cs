using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace KingTacToe.Core.Entities
{
    internal class CheckStuff
    {

        public static bool IsTheWinner(ref bool winner)
        {
            //Rows
            if (GameProps.buttons[0].Content == GameProps.buttons[1].Content && GameProps.buttons[1].Content == GameProps.buttons[2].Content && (string)GameProps.buttons[0].Content != null)
            { return GameProps.Winner = winner = true; }
            if (GameProps.buttons[3].Content == GameProps.buttons[4].Content && GameProps.buttons[4].Content == GameProps.buttons[5].Content && (string)GameProps.buttons[3].Content != null)
            { return GameProps.Winner = winner = true; }
            if (GameProps.buttons[6].Content == GameProps.buttons[7].Content && GameProps.buttons[7].Content == GameProps.buttons[8].Content && (string)GameProps.buttons[6].Content != null)
            { return GameProps.Winner = winner = true; }

            //Columns
            if (GameProps.buttons[0].Content == GameProps.buttons[3].Content && GameProps.buttons[3].Content == GameProps.buttons[6].Content && (string)GameProps.buttons[0].Content != null)
            { return GameProps.Winner = winner = true; }
            if (GameProps.buttons[1].Content == GameProps.buttons[4].Content && GameProps.buttons[4].Content == GameProps.buttons[7].Content && (string)GameProps.buttons[1].Content != null)
            { return GameProps.Winner = winner = true; }
            if (GameProps.buttons[2].Content == GameProps.buttons[5].Content && GameProps.buttons[5].Content == GameProps.buttons[8].Content && (string)GameProps.buttons[2].Content != null)
            { return GameProps.Winner = winner = true; }
            //Diagonal
            if (GameProps.buttons[0].Content == GameProps.buttons[4].Content && GameProps.buttons[4].Content == GameProps.buttons[8].Content && (string)GameProps.buttons[0].Content != null)
            { return GameProps.Winner = winner = true; }
            if (GameProps.buttons[6].Content == GameProps.buttons[4].Content && GameProps.buttons[4].Content == GameProps.buttons[2].Content && (string)GameProps.buttons[6].Content != null)
            { return GameProps.Winner = winner = true; }

            else { return GameProps.Winner = winner = false; }

        }

        public static bool CheckBoard(ref bool played)
        {
            //Rows Check
            if (GameProps.buttons[0].Content == GameProps.buttons[1].Content && GameProps.buttons[2].Content == null && GameProps.buttons[0].Content != null) 
            { GameProps.buttons[2].Content = "O"; GameProps.lastButton = GameProps.buttons[2]; GameProps.buttons[2].Background = Brushes.LightSlateGray; return played = true; }  
            if(GameProps.buttons[1].Content == GameProps.buttons[2].Content && GameProps.buttons[0].Content == null && GameProps.buttons[1].Content != null) 
            { GameProps.buttons[0].Content = "O"; GameProps.lastButton = GameProps.buttons[0]; GameProps.buttons[0].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[0].Content == GameProps.buttons[2].Content && GameProps.buttons[1].Content == null && GameProps.buttons[0].Content != null)
			{ GameProps.buttons[1].Content = "O"; GameProps.lastButton = GameProps.buttons[1]; GameProps.buttons[1].Background = Brushes.LightSlateGray; return played = true; }

			if (GameProps.buttons[3].Content == GameProps.buttons[4].Content && GameProps.buttons[5].Content == null && GameProps.buttons[3].Content != null)
			{ GameProps.buttons[5].Content = "O"; GameProps.lastButton = GameProps.buttons[5]; GameProps.buttons[5].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[3].Content == GameProps.buttons[5].Content && GameProps.buttons[4].Content == null && GameProps.buttons[3].Content != null)
			{ GameProps.buttons[4].Content = "O"; GameProps.lastButton = GameProps.buttons[4]; GameProps.buttons[4].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[4].Content == GameProps.buttons[5].Content && GameProps.buttons[3].Content == null && GameProps.buttons[4].Content != null)
			{ GameProps.buttons[3].Content = "O"; GameProps.lastButton = GameProps.buttons[3]; GameProps.buttons[3].Background = Brushes.LightSlateGray; return played = true; }

			if (GameProps.buttons[6].Content == GameProps.buttons[7].Content && GameProps.buttons[8].Content == null && GameProps.buttons[6].Content != null)
			{ GameProps.buttons[8].Content = "O"; GameProps.lastButton = GameProps.buttons[8]; GameProps.buttons[8].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[6].Content == GameProps.buttons[8].Content && GameProps.buttons[7].Content == null && GameProps.buttons[6].Content != null)
			{ GameProps.buttons[7].Content = "O"; GameProps.lastButton = GameProps.buttons[7]; GameProps.buttons[7].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[7].Content == GameProps.buttons[8].Content && GameProps.buttons[6].Content == null && GameProps.buttons[7].Content != null)
			{ GameProps.buttons[6].Content = "O"; GameProps.lastButton = GameProps.buttons[6]; GameProps.buttons[6].Background = Brushes.LightSlateGray; return played = true; }

			//Columns Check
			if (GameProps.buttons[0].Content == GameProps.buttons[3].Content && GameProps.buttons[6].Content == null && GameProps.buttons[0].Content != null)
			{ GameProps.buttons[6].Content = "O"; GameProps.lastButton = GameProps.buttons[6]; GameProps.buttons[6].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[0].Content == GameProps.buttons[6].Content && GameProps.buttons[3].Content == null && GameProps.buttons[0].Content != null)
			{ GameProps.buttons[3].Content  = "O"; GameProps.lastButton = GameProps.buttons[3]; GameProps.buttons[3].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[3].Content == GameProps.buttons[6].Content && GameProps.buttons[0].Content == null && GameProps.buttons[3].Content != null)
			{ GameProps.buttons[0].Content = "O"; GameProps.lastButton = GameProps.buttons[0]; GameProps.buttons[0].Background = Brushes.LightSlateGray; return played = true; }

			if (GameProps.buttons[1].Content == GameProps.buttons[4].Content && GameProps.buttons[7].Content == null && GameProps.buttons[1].Content != null)
			{ GameProps.buttons[7].Content = "O"; GameProps.lastButton = GameProps.buttons[7]; GameProps.buttons[7].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[1].Content == GameProps.buttons[7].Content && GameProps.buttons[4].Content == null && GameProps.buttons[1].Content != null)
			{ GameProps.buttons[4].Content = "O"; GameProps.lastButton = GameProps.buttons[4]; GameProps.buttons[4].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[4].Content == GameProps.buttons[7].Content && GameProps.buttons[1].Content == null && GameProps.buttons[4].Content != null)
			{ GameProps.buttons[1].Content = "O"; GameProps.lastButton = GameProps.buttons[1]; GameProps.buttons[1].Background = Brushes.LightSlateGray; return played = true; }

			if (GameProps.buttons[2].Content == GameProps.buttons[5].Content && GameProps.buttons[8].Content == null && GameProps.buttons[2].Content != null)
			{ GameProps.buttons[8].Content = "O"; GameProps.lastButton = GameProps.buttons[8]; GameProps.buttons[8].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[2].Content == GameProps.buttons[8].Content && GameProps.buttons[5].Content == null && GameProps.buttons[2].Content != null)
			{ GameProps.buttons[5].Content = "O"; GameProps.lastButton = GameProps.buttons[5]; GameProps.buttons[5].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[5].Content == GameProps.buttons[8].Content && GameProps.buttons[2].Content == null && GameProps.buttons[5].Content != null)
			{ GameProps.buttons[2].Content = "O"; GameProps.lastButton = GameProps.buttons[2]; GameProps.buttons[2].Background = Brushes.LightSlateGray; return played = true; }

			//Diagonal Check
			if (GameProps.buttons[0].Content == GameProps.buttons[4].Content && GameProps.buttons[8].Content == null && GameProps.buttons[0].Content != null)
			{ GameProps.buttons[8].Content = "O"; GameProps.lastButton = GameProps.buttons[8]; GameProps.buttons[8].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[0].Content == GameProps.buttons[0].Content && GameProps.buttons[4].Content == null && GameProps.buttons[0].Content != null)
			{ GameProps.buttons[4].Content = "O"; GameProps.lastButton = GameProps.buttons[4]; GameProps.buttons[4].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[4].Content == GameProps.buttons[8].Content && GameProps.buttons[0].Content == null && GameProps.buttons[4].Content != null)
			{ GameProps.buttons[0].Content = "O"; GameProps.lastButton = GameProps.buttons[0]; GameProps.buttons[0].Background = Brushes.LightSlateGray; return played = true; }

			if (GameProps.buttons[6].Content == GameProps.buttons[4].Content && GameProps.buttons[2].Content == null && GameProps.buttons[6].Content != null)
			{ GameProps.buttons[2].Content = "O"; GameProps.lastButton = GameProps.buttons[2]; GameProps.buttons[2].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[6].Content == GameProps.buttons[2].Content && GameProps.buttons[4].Content == null && GameProps.buttons[6].Content != null)
			{ GameProps.buttons[4].Content = "O"; GameProps.lastButton = GameProps.buttons[4]; GameProps.buttons[4].Background = Brushes.LightSlateGray; return played = true; }
			if (GameProps.buttons[4].Content == GameProps.buttons[2].Content && GameProps.buttons[6].Content == null && GameProps.buttons[4].Content != null)
			{ GameProps.buttons[6].Content = "O"; GameProps.lastButton = GameProps.buttons[6]; GameProps.buttons[6].Background = Brushes.LightSlateGray; return played = true; }
			else { return played = false; }
         }
        public static bool IsTieGame(bool winner, ref int round)
        {
            if (round == 9 && winner == false)
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
                if ((string)GameProps.lastButton.Content == "X")
                {
                    MessageBox.Show("Player X has won.");
                    GameProps.P1++;
                    king.Player1.Content = "P1 - X: " + GameProps.P1;
                    ClickEventsLogic.NewGame(king, ref player, ref round, ref winner);
                }
                else if ((string)GameProps.lastButton.Content == "O")
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
