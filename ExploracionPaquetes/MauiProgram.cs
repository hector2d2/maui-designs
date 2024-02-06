using Camera.MAUI;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Microsoft.Maui.LifecycleEvents;
using SkiaSharp.Views.Maui.Controls.Hosting;

using ExploracionPaquetes.Src.Design.Views;
using ExploracionPaquetes.Src.Security.Views;
using Plugin.LocalNotification;
#if IOS
using ExploracionPaquetes.Platforms.iOS;
using Plugin.Firebase.Bundled.Platforms.iOS;
#else

#endif

namespace ExploracionPaquetes;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiMaps()
            .UseMauiApp<App>()
            .RegisterFirebaseServices()
            .UseMauiCompatibility()
            .UseSkiaSharp()
            .UseMauiCameraView()
            .UseLocalNotification(config =>
            config.AddiOS(iOS =>
            {
#if IOS
                iOS.SetCustomUserNotificationCenterDelegate(new CustomUserNotificationCenterDelegate());
#endif
            })
            )
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FontAwesomeBrands-Regular-400.otf", "FABR");
                fonts.AddFont("FontAwesomeFree-Regular-400.otf", "FAR");
                fonts.AddFont("FontAwesomeFree-Solid-900.otf", "FAS");
            })
            .ConfigureEssentials(essentials =>
            {
                essentials
                    .AddAppAction("biometrico", "Ir a Biometricos")
                    .AddAppAction("configuracion", "Ir a Configuracion")
                    .OnAppAction(HandleAppActions);
            });
        


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static void HandleAppActions(AppAction appAction)
    {
        App.Current.Dispatcher.Dispatch(async () =>
        {
           
            var page = appAction.Id switch
            {
                "biometrico" => new FingerPrintView(),
                "configuracion" => new SettingsView(),
                _ => default(Page)
            };

            if (page != null)
            {
                await Application.Current.MainPage.Navigation.PopToRootAsync();
                await Application.Current.MainPage.Navigation.PushAsync(page);
            }
        });
    }

    private static MauiAppBuilder RegisterFirebaseServices(this MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events => {
#if IOS
            events.AddiOS(iOS => iOS.WillFinishLaunching((app, launchOptions) => {                
                                 
                //CrossFirebase.Initialize(CreateCrossFirebaseSettings());                               
                return false;
            }));
#else
            //events.AddAndroid(android => android.OnCreate((activity, _) =>
            //    CrossFirebase.Initialize(activity, CreateCrossFirebaseSettings())));
#endif

        });

        //builder.Services.AddSingleton(_ => CrossFirebaseAuth.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseCloudMessaging.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseDynamicLinks.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseFunctions.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseStorage.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseRemoteConfig.Current);
        //builder.Services.AddSingleton(_ => CrossFirebaseAuth.Current);
        return builder;
    }    

    
}

