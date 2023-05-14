using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KingTacToe
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	/// //Building a TicTacToe Game in a Wpf app made of 3*3 "game" buttons, an "End button", a "Reset button and a "New Game" button.
	//I always wanna start with the player that uses crosses (player x). Once he presses a game button a cross appears on it. We go to the second round.
	//Then there should be a player change to the circle using player (player Y).
	//With the same mechanics and we change player on every game button click. 
	//Once a player has a row or a column of his sign he wins the round and he gets a point on his win counter.
	//If there is no winner after 9 rounds then it is a draw. Add a point to that counter.


	public partial class MainWindow : Window
	{
		int player = 2;
		int p1;
		int p2 = 0;
		int draw = 0;
		int round = 0;
		bool winner = false;
		string currentPlayerMark = "X";
		string prevPlayerMark = "O";

		bool IsDraw()
		{
			if (round == 9 && (winner == false))
			{ 
				return true;
			}
			else { return false; }
		}
		bool IsWinner(bool winner)
		{
			//Rows
			if ((A00.Content == A01.Content) && (A01.Content == A02.Content) && (string)A00.Content != null)
				return winner = true;
			if (((string)A10.Content == (string)A11.Content) && ((string)A11.Content == (string)A12.Content) && (string)A10.Content != null)
				return winner = true;
			if (((string)A20.Content == (string)A21.Content) && ((string)A21.Content == (string)A22.Content) && (string)A20.Content != null)
				return winner = true;

			//Columns
			if (((string?)A00.Content == (string?)A10.Content) && ((string?)A10.Content == (string?)A20.Content) && (string?)A00.Content != null)
				return winner = true;
			if (((string)A01.Content == (string)A11.Content) && ((string)A11.Content == (string)A21.Content) && (string)A01.Content != null)
				return winner = true;
			if (((string)A02.Content == (string)A12.Content) && ((string)A12.Content == (string)A22.Content) && (string)A02.Content != null)
				return winner = true;
			//Diagonal
			if (((string?)A00.Content == (string)A11.Content) && ((string)A11.Content == (string)A22.Content) && (string)A00.Content != null)
				return winner = true;
			if (((string?)A20.Content == (string)A11.Content) && ((string)A11.Content == (string?)A02.Content) && (string)A20.Content != null)
				return winner = true;

			else { return winner = false; }
			
		}

		public MainWindow()
		{
			
			InitializeComponent();
			var converter = new System.Windows.Media.BrushConverter();
			var brush = (Brush)converter.ConvertFromString("#292828");
			King.Background = brush;
			//Fill = new SolidColorBrush(Color.FromArgb(0xff, 0xff, 0x90))
			Player1.Foreground = Brushes.White;
			Player2.Foreground = Brushes.White;
			Draw.Foreground = Brushes.White;
			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;
		}

		private void Button_Clicks(object sender, RoutedEventArgs e)
		{						
			Button button = (Button)sender;
			if (button.Content == null)
			{
				if (player % 2 == 0)
				{
					button.FontStyle = FontStyles.Italic; 
					button.Content = currentPlayerMark;
					player++;
					++round;
				}
				else
				{
					button.FontStyle = FontStyles.Italic;
					button.Content = prevPlayerMark;
					player++;
					++round;
				}
				
				if (IsWinner(winner).Equals(true))
				{
					if (button.Content == "X")
					{
						MessageBox.Show("Player X has won.");
						p1++;
						Player1.Content = "P1 - X: " + p1;
						NewGameAfterWin();
					}
					else if (button.Content == "O")
					{
						MessageBox.Show("Player O has won.");
						p2++;
						Player2.Content = "P2 - O: " + p2;
						NewGameAfterWin();
					}
				}
				else if (IsDraw() == true)
				{
					MessageBox.Show("Tie Game.");
					draw++;
					Draw.Content = "Draw: " + draw;
					NewGameAfterWin();
				}
			}

			
		}

		private void end_btn_Click(object sender, RoutedEventArgs e)
		{
			King.Close();
		}

		private void reset_btn_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			A00.Content = null;
			A01.Content = null;
			A02.Content = null;
			A10.Content = null;
			A11.Content = null;
			A12.Content = null;
			A20.Content = null;
			A21.Content = null;
			A22.Content = null;
			player = 2;
			p1 = 0;
			p2 = 0;
			draw = 0;
			round = 0;
			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;
		}
		private void newGame_btn_Click(object sender, RoutedEventArgs e)
		{
			NewGame();
		}
		private void NewGame()
		{
			A00.Content = null;
			A01.Content = null;
			A02.Content = null;
			A10.Content = null;
			A11.Content = null;
			A12.Content = null;
			A20.Content = null;
			A21.Content = null;
			A22.Content = null;
			round = 0;
			player = 2;
			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;
		}
		private void NewGameAfterWin()
		{
			A00.Content = null;
			A01.Content = null;
			A02.Content = null;
			A10.Content = null;
			A11.Content = null;
			A12.Content = null;
			A20.Content = null;
			A21.Content = null;
			A22.Content = null;
			round = 0;
			player = 2;
			string temp = currentPlayerMark;
			currentPlayerMark = prevPlayerMark;
			prevPlayerMark = temp;
			
			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;
		}
	}
}

