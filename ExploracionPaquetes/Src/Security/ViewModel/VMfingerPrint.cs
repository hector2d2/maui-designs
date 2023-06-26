using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace ExploracionPaquetes.Src.Security.ViewModel
{
	[ObservableObject]
	public partial class VMfingerPrint
	{

		[RelayCommand]
		async void Authentication()
		{
            var isAvailable = await CrossFingerprint.Current.IsAvailableAsync();

            if (isAvailable)
            {
                var request = new AuthenticationRequestConfiguration
                ("Login using biometrics", "Confirm login with your biometrics");

                var result = await CrossFingerprint.Current.AuthenticateAsync(request);

                if (result.Authenticated)
                {
                    await Application.Current.MainPage.DisplayAlert("Authenticated!", "Access granted", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Not authenticated!", "Access denied", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("No esta habilitado el uso de huella", "No esta habilitado el uso de huella", "OK");
            }
        }
	}
}

