using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KingTacToe
{
    class GameProps
    {
		public static bool winner;
		public static int round;
		public static int player = 2;
		public static ref int Player => ref player;		
		public static int P1 { get; set; }
		public static int P2 { get; set; }		
		public static int TieGame { get; set; }
		public static ref int Round => ref round;
		public static ref bool Winner => ref winner;
		public static int Index { get; set; }
		public static string CurrentPlayerMark { get; set; } = "X";
		public static string PrevPlayerMark { get; set; } = "O";

		public static List<Button> buttons = new();


		public GameProps() { }
		public GameProps(int player, int p1, int p2, int draw, int round, bool winner,string currentPlayerMark, string prevPlayerMark) 
        { 
            Player = player;
            P1 = p1;
            P2 = p2;
            TieGame = draw;
            Round = round;
			Winner = winner;
			CurrentPlayerMark = currentPlayerMark;
			PrevPlayerMark = prevPlayerMark;
        }
	}
}
