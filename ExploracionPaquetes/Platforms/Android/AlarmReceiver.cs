using System;
using Android.App;
using Android.Content;
using Plugin.LocalNotification;

namespace ExploracionPaquetes.Platforms.Android
{
    [BroadcastReceiver(Exported = true, Enabled = true)]
    public class AlarmReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("Hola");
            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = "HOla",
                Subtitle = "Mundo",
                Description = "Local notificacion.",
            };
            LocalNotificationCenter.Current.Show(request);
        }
    }
}

