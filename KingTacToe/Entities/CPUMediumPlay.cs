using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace KingTacToe.Core.Entities
{
    internal class CPUMediumPlay
    {
		static Random random = new();

		public static async void CPUMediumAlgorithm(Button button, MainWindow mainWindow)
		{

			if (button.Content == null)
			{
				if (GameProps.Player % 2 == 0)
				{
					button.FontStyle = FontStyles.Italic;
					GameProps.Index = GameProps.buttons.IndexOf(button);
					button.Content = "X";
					GameProps.lastButton = GameProps.buttons[GameProps.Index];
					GameProps.buttons[GameProps.Index].Background = Brushes.DimGray;
					GameProps.buttons[GameProps.Index].Content = button.Content;
					
					GameProps.Player++;
					++GameProps.Round;
					CheckStuff.IsTheWinner(ref GameProps.Winner);
					CheckStuff.GameDone(mainWindow, GameProps.Index, ref GameProps.Round, ref GameProps.Player, ref GameProps.Winner);
					mainWindow.IsEnabled = false;
				}

				if (GameProps.Winner != true && GameProps.Player % 2 != 0)
				{
					bool played = false;
					
					await Task.Factory.StartNew(() => Thread.Sleep(750))
					.ContinueWith((t) =>
					{
						mainWindow.IsEnabled = true;
						CheckStuff.CheckBoard(ref played);
						
						if (!played)
						{
							GameProps.Index = random.Next(GameProps.buttons.Count);

							if (GameProps.buttons[GameProps.Index].Content != null && GameProps.Winner == false)
							{
								while (GameProps.buttons[GameProps.Index].Content != null && GameProps.Winner == false)
								{
									GameProps.Index = random.Next(GameProps.buttons.Count);
								}

								GameProps.buttons[GameProps.Index].Content = "O";
								GameProps.buttons[GameProps.Index].Background = Brushes.LightSlateGray;
							}
							else if (GameProps.buttons[GameProps.Index].Content == null && GameProps.Winner == false)
							{
								GameProps.buttons[GameProps.Index].Content = "O";
								GameProps.buttons[GameProps.Index].Background = Brushes.LightSlateGray;
							}
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
	}
}
