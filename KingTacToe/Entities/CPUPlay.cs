using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KingTacToe.Core.Entities
{
    class CPUPlay
    {

        static Random random = new();

        public static void CPUAlgorithm(Button button, MainWindow mainWindow)
        {

            if (button.Content == null)
            {
                if (GameProps.Player % 2 == 0)
                {
                    button.FontStyle = FontStyles.Italic;
                    GameProps.Index = GameProps.buttons.IndexOf(button);
                    button.Content = "X";
                    GameProps.buttons[GameProps.Index].Background = Brushes.DimGray;
                    GameProps.buttons[GameProps.Index].Content = button.Content;
					GameProps.lastButton = GameProps.buttons[GameProps.Index];
					GameProps.Player++;
                    ++GameProps.Round;
                    CheckStuff.IsTheWinner(ref GameProps.Winner);
                    CheckStuff.GameDone(mainWindow, GameProps.Index, ref GameProps.Round, ref GameProps.Player, ref GameProps.Winner);
                }

                if (GameProps.Winner != true && GameProps.Player % 2 != 0)
                {
                    mainWindow.IsEnabled = false;
                    Task.Factory.StartNew(() => Thread.Sleep(750))
                    .ContinueWith((t) =>
                    {
                        mainWindow.IsEnabled = true;
                        GameProps.Index = random.Next(GameProps.buttons.Count);

                        if (GameProps.buttons[GameProps.Index].Content != null && GameProps.Winner == false)
                        {
                            while (GameProps.buttons[GameProps.Index].Content != null && GameProps.Winner == false)
                            {
                                GameProps.Index = random.Next(GameProps.buttons.Count);
                            }

                            GameProps.buttons[GameProps.Index].Content = "O";
                            GameProps.buttons[GameProps.Index].Background = Brushes.LightSlateGray;
							GameProps.lastButton = GameProps.buttons[GameProps.Index];

						}
						else if (GameProps.buttons[GameProps.Index].Content == null && GameProps.Winner == false)
                        {
                            GameProps.buttons[GameProps.Index].Content = "O";
                            GameProps.buttons[GameProps.Index].Background = Brushes.LightSlateGray;
							GameProps.lastButton = GameProps.buttons[GameProps.Index];

						}
						GameProps.Player++;
                        ++GameProps.Round;
                        CheckStuff.IsTheWinner(ref GameProps.Winner);
                        CheckStuff.GameDone(mainWindow, GameProps.Index, ref GameProps.Round, ref GameProps.Player, ref GameProps.Winner);
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        public static void AddButton(Button button, List<Button> buttons)
        {
            buttons.Add(button);
        }
        public static void ResetButtons(List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                button.IsEnabled = true;
                button.Content = null;
            }
        }
        public static void RemoveAllButtons(List<Button> buttons)
        {
            buttons.Clear();
        }

    }
}

