using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Security.Views;

namespace ExploracionPaquetes.Src.Security.ViewModel
{
	[ObservableObject]
	public partial class VMsecurityHome
	{
		public VMsecurityHome()
		{
		}

		[RelayCommand]
		void GoToFingerPrint()
		{
			Application.Current.MainPage.Navigation.PushAsync(new FingerPrintView());
		}

		[RelayCommand]
		void GoToCamera()
		{
			Application.Current.MainPage.Navigation.PushAsync(new CameraView());
		}

        [RelayCommand]
        void GoToInvoqueNativeCode()
        {
            Application.Current.MainPage.Navigation.PushAsync(new InvoqueNativeCodeView());
        }

        [RelayCommand]
        void GoToAlert()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AlertView());
        }
    }
}

