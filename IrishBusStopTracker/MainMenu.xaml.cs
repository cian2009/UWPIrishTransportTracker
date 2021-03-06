﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace IrishBusStopTracker
{
	public sealed partial class MainMenu : Page
	{
		// Main menu page setup
		public MainMenu()
		{
			this.InitializeComponent();

			// Sets up sound player
			ElementSoundPlayer.State = ElementSoundPlayerState.On;
			ElementSoundPlayer.Volume = 0.5;
		}

		// Button fuction for when user presses 'Add_Transport' button in xaml
		private void Add_Transport(object sender, RoutedEventArgs e)
		{

			// Moves user to AddTransport.xaml page
			this.Frame.Navigate(typeof(AddTransport));
		}

		// Button fuction for when user presses 'View_Busses' button in xaml
		private void View_Busses(object sender, RoutedEventArgs e)
		{
			// Moves user to BusTransport.xaml page
			this.Frame.Navigate(typeof(BusTransport));
		}

		// Button fuction for when user presses 'View_Trains' button in xaml
		private void View_Trains(object sender, RoutedEventArgs e)
		{
			// Moves user to TrainMenu.xaml page
			this.Frame.Navigate(typeof(TrainMenu));
		}

		// Button fuction for when user presses 'View_Luas' button in xaml
		private void View_Luas(object sender, RoutedEventArgs e)
		{
			// Moves user to LuasMenu.xaml page
			this.Frame.Navigate(typeof(LuasMenu));
		}
	}
}