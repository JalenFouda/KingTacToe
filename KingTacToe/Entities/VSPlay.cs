using System.Windows.Controls;
using System.Windows.Media;

namespace KingTacToe.Core.Entities
{
    class VSPlay
    {
        public static Brush color = Brushes.DimGray;
        public static Brush color2 = Brushes.LightSlateGray;
        public static void GameAlgorithm(Button button, MainWindow mainWindow)
        {
            if (button.Content == null)
            {
                if (GameProps.Player % 2 == 0)
                {
                    button.Content = GameProps.CurrentPlayerMark;
                    button.Background = color;
                    GameProps.Index = GameProps.buttons.IndexOf(button);
                    GameProps.lastButton = GameProps.buttons[GameProps.Index];
					GameProps.Round++;
                    GameProps.Player++;
                    CheckStuff.IsTheWinner(ref GameProps.Winner);
                    CheckStuff.GameDone(mainWindow, GameProps.Index, ref GameProps.Round, ref GameProps.Player, ref GameProps.Winner);
                }
                else if (GameProps.Player % 2 != 0)
                {
                    button.Content = GameProps.PrevPlayerMark;
                    button.Background = color2;
                    GameProps.Index = GameProps.buttons.IndexOf(button);
					GameProps.lastButton = GameProps.buttons[GameProps.Index];
					GameProps.Round++;
                    GameProps.Player++;
                    CheckStuff.IsTheWinner(ref GameProps.Winner);
                    CheckStuff.GameDone(mainWindow, GameProps.Index, ref GameProps.Round, ref GameProps.Player, ref GameProps.Winner);
                }
            }
        }
    }
}
