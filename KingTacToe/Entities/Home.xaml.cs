using System;
using System.Collections.Generic;
using System.Linq;
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
using KingTacToe.Core;
using KingTacToe.Core.Entities;

namespace KingTacToe
{
    /// <summary>
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Window
    {

       
		public Home()
        {
            InitializeComponent();
        }
		void GameStart()
		{
            MainWindow mainwindow = new();
            Close();
            mainwindow.ShowDialog();
		}
		public void Game1v1_Click(object sender, RoutedEventArgs e)
		{
            ClickButton.button1WasClicked = true;
            GameStart();
		}

		public void GameCPU_Click(object sender, RoutedEventArgs e)
		{
            PickLevel pick = new();
            Close();
			pick.ShowDialog();
		}

		private void End_Click(object sender, RoutedEventArgs e)
		{
            King.Close();
        }
    }
}
