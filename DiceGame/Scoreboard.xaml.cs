using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiceGame
{
	/// <summary>
	/// Interaction logic for Scoreboard.xaml
	/// </summary>
	public partial class Scoreboard : UserControl
	{
		public List<Player> Players { get; set; }
		public ObservableCollection<Goal> Goals { get; set; }


		public Scoreboard()
		{
			InitializeComponent();
			Goals = new ObservableCollection<Goal>(FiveDiceBuilder.Build());
			this.DataContext = this;
		}

		//private Grid CreateGrid()
		//{

		//}
	}
}
