#if ANDROID
    using Android.App;
    using Android.Content;
    using Android.OS;
    using ExploracionPaquetes.Platforms.Android;
#endif 
using Plugin.LocalNotification;
using Application = Microsoft.Maui.Controls.Application;

namespace ExploracionPaquetes.Src.Security.Views;

public partial class AlertView : ContentPage
{
	public AlertView()
	{
		InitializeComponent();
	}

    void BtnSetAlarm_Clicked(System.Object sender, System.EventArgs e)
    {
        var currentDateTime = DateTime.Now;
        var dateTimeSelected = ConvertDateSelectedToDateTime();
        var minutesDifference = DifferenceDatesInMinutes(dateTimeSelected, currentDateTime);
        SetAlarmAndroid(minutesDifference, "pendingIntent");
        Application.Current.MainPage.DisplayAlert("Fecha", $"Alerta se notificara: {minutesDifference}", "ok");
    }

    async void BtnSetNotification_Clicked(System.Object sender, System.EventArgs e)
    {
        var resp = await LocalNotificationCenter.Current.RequestNotificationPermission();

        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "HOla",
            Subtitle = "Mundo",
            Description = "Local notificacion.",
            CategoryType = NotificationCategoryType.Alarm,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddMinutes(3),
                NotifyRepeatInterval = TimeSpan.FromDays(1)
            },
            Android = new Plugin.LocalNotification.AndroidOption.AndroidOptions
            {
                Priority = Plugin.LocalNotification.AndroidOption.AndroidPriority.Max
            }
        };
        var a = LocalNotificationCenter.Current.Show(request);
        var list = await LocalNotificationCenter.Current.GetPendingNotificationList();
        var b = await LocalNotificationCenter.Current.GetDeliveredNotificationList();
       
    }

    void BtnDateDifferences_Clicked(System.Object sender, System.EventArgs e)
    {
        var a = DP.Date.Day;
        var b = TP.Time;
        var day = DP.Date.Day;
        var month = DP.Date.Month;
        var year = DP.Date.Year;
        var hour = TP.Time.Hours;
        var minute = TP.Time.Minutes;
        var date = $"{month}/{day}/{year} {hour}:{minute}";
        DateTime selectDate = DateTime.Parse(date);
        var currentDateTime = DateTime.Now;
        var differenceDate = selectDate - currentDateTime;

        Application.Current.MainPage.DisplayAlert("Fecha",$"Total minutos: {differenceDate.TotalMinutes}","ok");
    }

    DateTime ConvertDateSelectedToDateTime()
    {
        var day = DP.Date.Day;
        var month = DP.Date.Month;
        var year = DP.Date.Year;
        var hour = TP.Time.Hours;
        var minute = TP.Time.Minutes;
        var date = $"{month}/{day}/{year} {hour}:{minute}";
        return DateTime.Parse(date);
    }

    double DifferenceDatesInMinutes(DateTime date1, DateTime date2)
    {
        return (date1 - date2).TotalMinutes;
    }

    void SetAlarmAndroid(double timeAlarmInMinutes, string nameIntent)
    {
#if ANDROID
        var intent = new Android.Content.Intent(Android.App.Application.Context, typeof(AlarmReceiver));
        var pendingIntent = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, intent, PendingIntentFlags.Immutable);
        intent.PutExtra(nameIntent, pendingIntent);
        var alarmManager = (AlarmManager)Android.App.Application.Context.GetSystemService(Context.AlarmService);
        long interval = (long)(60 * timeAlarmInMinutes * 1000);//AlarmManager.IntervalDay;  60 *  1 minuto 60,000  1 hora  3,600,000    2 horas 7,200,000

        alarmManager.Set(AlarmType.ElapsedRealtimeWakeup, SystemClock.ElapsedRealtime() + interval, pendingIntent);
#endif
    }
}
