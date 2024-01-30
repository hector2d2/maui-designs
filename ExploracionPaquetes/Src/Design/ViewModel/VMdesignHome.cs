using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Design.Views;

namespace ExploracionPaquetes.Src.Design.ViewModel
{
	[ObservableObject]
	public partial class VMdesignHome
	{
		public VMdesignHome()
		{
		}

		[RelayCommand]
		void GoToImagesWithMovement()
		{
			Application.Current.MainPage.Navigation.PushAsync(new ImagesWithMovement());
		}

		[RelayCommand]
		void GoToListDoingCard()
		{
            Application.Current.MainPage.Navigation.PushAsync(new ListDoingCardView());
        }

        [RelayCommand]
        void GoToCalendar()
        {
            Application.Current.MainPage.Navigation.PushAsync(new Calendar());
        }

        [RelayCommand]
        void GoToCalendarV2()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CalendarV2());
        }

        [RelayCommand]
        void GoToFoatingBottomMenu()
        {
            Application.Current.MainPage.Navigation.PushAsync(new FloatingBottomMenu());
        }

        [RelayCommand]
        void GoToMap()
        {
            Application.Current.MainPage.Navigation.PushAsync(new MyMapsView());
        }

        [RelayCommand]
        void GoToSettings()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }

        [RelayCommand]
        void GoToDrawerDesign()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DrawerDesignView());
        }

        [RelayCommand]
        void GoToReminders()
        {
            Application.Current.MainPage.Navigation.PushAsync(new RemindersView());
        }
    }
}

