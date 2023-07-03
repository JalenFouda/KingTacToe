using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace KingTacToe.Core.Entities
{
    internal class ClickEventsLogic
    {
        public static bool playerOrder = false;
        static List<Button> buttons = new();
        public static void ButtonList(MainWindow mainWindow, ref List<Button> buttons)
        {
            GameProps.buttons.Add(mainWindow.A00);
            GameProps.buttons.Add(mainWindow.A10);
            GameProps.buttons.Add(mainWindow.A20);
            GameProps.buttons.Add(mainWindow.A01);
            GameProps.buttons.Add(mainWindow.A11);
            GameProps.buttons.Add(mainWindow.A21);
            GameProps.buttons.Add(mainWindow.A02);
            GameProps.buttons.Add(mainWindow.A12);
            GameProps.buttons.Add(mainWindow.A22);

            buttons = GameProps.buttons;
        }
        public static void NewGame(MainWindow mainWindow, ref int player, ref int round, ref bool winner)
        {
            if (GameProps.Player % 2 == 0)
            {
                GameProps.Player = 2;
            }
            else if (GameProps.Player % 2 != 0)
            {
                GameProps.Player = 1;
            }

            player = GameProps.Player;
            GameProps.Round = 0;
            round = GameProps.Round;
            GameProps.Winner = false;
            winner = GameProps.Winner;

            foreach (Button button in GameProps.buttons)
            {
                button.Background = Brushes.LightGray;
            }
            CPUPlay.RemoveAllButtons(GameProps.buttons);
            ButtonList(mainWindow, ref buttons);
            CPUPlay.ResetButtons(GameProps.buttons);
        }

        public static void Reset(MainWindow mainWindow, ref int player, ref int round, ref bool winner, ref int p1, ref int p2, ref int draw)
        {
            GameProps.Player = 2;
            player = GameProps.Player;
            GameProps.Round = 0;
            round = GameProps.Round;
            GameProps.Winner = false;
            winner = GameProps.Winner;
            GameProps.P1 = 0;
            p1 = GameProps.P1;
            GameProps.P2 = 0;
            p2 = GameProps.P2;
            GameProps.TieGame = 0;
            draw = GameProps.TieGame;

            foreach (Button button in GameProps.buttons)
            {
                button.Background = Brushes.LightGray;
            }
            CPUPlay.RemoveAllButtons(GameProps.buttons);
            ButtonList(mainWindow, ref buttons);
            CPUPlay.ResetButtons(GameProps.buttons);
        }

        public static void ReturnReset(ref int player, ref int round, ref bool winner, ref int p1, ref int p2, ref int draw)
        {
            GameProps.Player = 2;
            player = GameProps.Player;
            GameProps.Round = 0;
            round = GameProps.Round;
            GameProps.Winner = false;
            winner = GameProps.Winner;
            GameProps.P1 = 0;
            p1 = GameProps.P1;
            GameProps.P2 = 0;
            p2 = GameProps.P2;
            GameProps.TieGame = 0;
            draw = GameProps.TieGame;

            foreach (Button button in GameProps.buttons)
            {
                button.Background = Brushes.LightGray;
            }
            CPUPlay.RemoveAllButtons(GameProps.buttons);
            //ButtonList(mainWindow, ref buttons);
            CPUPlay.ResetButtons(GameProps.buttons);
        }
    }
}
