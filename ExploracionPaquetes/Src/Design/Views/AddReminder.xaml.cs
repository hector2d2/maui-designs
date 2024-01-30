using Plugin.LocalNotification;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class AddReminder : ContentPage
{    
	public AddReminder()
	{
		InitializeComponent();
	}

    async void BtnCreateReminder_Clicked(System.Object sender, System.EventArgs e)
    {
        string subTitle = EntryNameReminder.Text;
        string description = EditorDescriptionReminder.Text;
        int idNotificarion = Preferences.Default.Get("currentIdNotification",0);
        DateTime dateSelected = ConvertDateSelectedToDateTime();
        var request = new NotificationRequest
        {
            NotificationId = idNotificarion,
            Title = "Recordatorio: " + "Hector Ricardo Tristan Mendez",
            Subtitle = subTitle,
            Description = description,
            CategoryType = NotificationCategoryType.Alarm,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = dateSelected,
            },
            Android = new Plugin.LocalNotification.AndroidOption.AndroidOptions
            {
                Priority = Plugin.LocalNotification.AndroidOption.AndroidPriority.Max
            }
        };
        var a = await LocalNotificationCenter.Current.Show(request);
        await Application.Current.MainPage.DisplayAlert("Recordatorio", "El recordatorio se ha guardado exitosamente.", "ok");
        Preferences.Default.Set("currentIdNotification", idNotificarion + 1);
    }

    DateTime ConvertDateSelectedToDateTime()
    {
        string date = "";
        var day = DateReminder.Date.Day;
        var month = DateReminder.Date.Month;
        var year = DateReminder.Date.Year;
        var hour = TimeReminder.Time.Hours;
        var minute = TimeReminder.Time.Minutes;
        var a = DateTime.Now.ToString();
#if ANDROID
        date = $"{month}/{day}/{year} {hour}:{minute}";
#endif
#if IOS
        date = $"{day}/{month}/{year} {hour}:{minute}";
#endif
        return DateTime.Parse(date);
    }
}
