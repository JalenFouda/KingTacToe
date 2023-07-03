using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KingTacToe.Core.Entities;

namespace KingTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// //Building a TicTacToe Game in a Wpf app made of 3*3 "game" GamePropsbuttons, an "End button", a "Reset button and a "New Game" button.
    /// //Put it on a website as well.


    public partial class MainWindow : Window
	{
		List<Button> buttons = new();

		bool winner;
		int player = 2;
		int p1;
		int p2 = 0;
		int draw = 0;
		int round = 0;
		Button clickedButton = new();

		public MainWindow()
		{
			InitializeComponent();

			Player1.Foreground = Brushes.White;
			Player2.Foreground = Brushes.White;
			Draw.Foreground = Brushes.White;

			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;

			if (GameProps.buttons.Count == 0) 
			{
				ButtonList(); 
				// Wenn Buttons nicht hier hinzugefügt werden sondern beim zurückgehen zum Home-Menü, werden sie nicht erkannt. Wieso?
			}
		}

		public void ButtonList()
		{
			ClickEventsLogic.ButtonList(King, ref buttons);
		}

		public void IsWinner()
		{
			CheckStuff.IsTheWinner(ref winner);
		}

		private void Button_Clicks(object sender, RoutedEventArgs e)
		{
			clickedButton = (Button)sender;

			if (ClickButton.button1WasClicked == true)
			{
				VSPlay.GameAlgorithm(clickedButton, King);
			}
			else if (ClickButton.buttonCWasClicked == true) 
			{
				CPUPlay.CPUAlgorithm(clickedButton, King);
			}
			else if (ClickButton.buttonHWasClicked == true)
			{
				CPUMediumPlay.CPUMediumAlgorithm(clickedButton, King);
			}
		}

		private void End_btn_Click(object sender, RoutedEventArgs e)
		{
			King.Close();
		}

		private void Reset_btn_Click(object sender, RoutedEventArgs e)
		{
			ClickEventsLogic.Reset(King, ref player, ref round, ref winner, ref p1, ref p2, ref draw);
			
			Player1.Content = "P1 - X: " + p1;
			Player2.Content = "P2 - O: " + p2;
			Draw.Content = "Draw: " + draw;
		}

		private void NewGame_btn_Click(object sender, RoutedEventArgs e)
		{
			ClickEventsLogic.NewGame(King, ref player, ref round, ref winner);
		}

		private void Return_Click(object sender, RoutedEventArgs e)
		{
			Home homewindow = new();
			ClickEventsLogic.ReturnReset(ref player, ref round, ref winner, ref p1, ref p2, ref draw);
			ClickButton.buttonCWasClicked = false;
			ClickButton.button1WasClicked = false;
			Close();
			homewindow.ShowDialog();
		}
	}
} 

