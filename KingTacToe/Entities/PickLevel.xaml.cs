using KingTacToe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KingTacToe.Core
{
	/// <summary>
	/// Interaction logic for PickLevel.xaml
	/// </summary>
	public partial class PickLevel : Window
	{
		public PickLevel()
		{
			InitializeComponent();
		}
		void GameStart()
		{
			MainWindow mainwindow = new();
			Close();
			mainwindow.ShowDialog();
		}
		public void Easy(object sender, RoutedEventArgs e)
		{
			ClickButton.buttonCWasClicked = true;
			GameStart();
		}
		public void Medium(object sender, RoutedEventArgs e)
		{
			ClickButton.buttonHWasClicked = true;
			GameStart();
		}
	}
}
