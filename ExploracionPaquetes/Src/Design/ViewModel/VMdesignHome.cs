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
	}
}

