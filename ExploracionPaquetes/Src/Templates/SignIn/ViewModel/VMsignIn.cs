using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Firebase.Auth;

namespace ExploracionPaquetes.Src.Templates.SignIn.ViewModel
{
	[ObservableObject]
	public partial class VMsignIn
	{
		[ObservableProperty]
		string email = "hector_tristan_dev@hotmail.com";
		[ObservableProperty]
		string password = "hector123";

		public VMsignIn()
		{
		}

		[RelayCommand]
		async Task Login()
		{
			try
			{                
                await CrossFirebaseAuth.Current.CreateUserAsync(Email, Password);
                await Application.Current.MainPage.DisplayAlert("Creacion de empleados", "Empleado correctamente", "OK");
            }
			catch (Exception ex)
			{
				await Application.Current.MainPage.DisplayAlert("error",ex.Message,"OK");    
			}

        }
	}
}

