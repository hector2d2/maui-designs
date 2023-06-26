using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Design.Views;
using ExploracionPaquetes.Src.Security.Views;

namespace ExploracionPaquetes.Src.Home.ViewModel
{
	[ObservableObject]
	public partial class VMhome
	{
		public VMhome()
		{
		}

		[RelayCommand]
		void GoToSecurityViews()
		{
			Application.Current.MainPage.Navigation.PushAsync(new SecurityHome());
		}

		[RelayCommand]
		void GoToDesignViews()
		{
            Application.Current.MainPage.Navigation.PushAsync(new DesignHomeView());
        }
	}
}

