using System.Collections.ObjectModel;
using Plugin.LocalNotification;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class RemindersView : ContentPage
{
    string nameMonth;
    DateTime currentDate = DateTime.Now;
    ObservableCollection<string> numbersday = new();
    ObservableCollection<NotificationRequest> myNotifications = new();
    int year;
    int month;
    double maxHeightBS = 0;
    double minHeightBS = 0;

    public ObservableCollection<string> Numbersday
    {
        get => numbersday;
        set
        {
            numbersday = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<NotificationRequest> MyNotifications
    {
        get => myNotifications;
        set
        {
            myNotifications = value;
            OnPropertyChanged();
        }
    }

    public RemindersView()
	{
		InitializeComponent();
        BindingContext = this;
        InitDate();
        GetAllReminders();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetAllReminders();
    }

    void ImgAddReminder_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		Navigation.PushAsync(new AddReminder());
    }

    void MenuToday_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ReminderOfDay.IsVisible = true;
        ReminderOfCalendar.IsVisible = false;
        ImgToday.Color = Colors.Gold;
        TxtMenuInit.TextColor = Colors.Gold;
        ImgCalendar.Color = Colors.White;
        TxtMenuEvent.TextColor = Colors.White;
    }

    void MenuCalendar_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ReminderOfCalendar.IsVisible = true;
        ReminderOfDay.IsVisible = false;
        ImgToday.Color = Colors.White;
        TxtMenuInit.TextColor = Colors.White;
        ImgCalendar.Color = Colors.Gold;
        TxtMenuEvent.TextColor = Colors.Gold;
    }
    void InitDate()
    {
        year = currentDate.Year;
        month = currentDate.Month;
        nameMonth = getNameMonth(currentDate.Month);
        TxtNameMonth.Text = nameMonth;
        BuildDaysCalendar(month);
    }

    void BuildDaysCalendar(int numberMonth)
    {
        Numbersday.Clear();
        //var dateSelected = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day);
        var daysOfMonth = DateTime.DaysInMonth(year, numberMonth);
        var initDateTime = new DateTime(year, numberMonth, 1);
        var dayOfWeekInit = (int)initDateTime.DayOfWeek;
        var indexDay = 1;
        for (int i = 0; i < 42; i++)
        {
            if (i >= dayOfWeekInit && daysOfMonth >= indexDay)
            {
                Numbersday.Add($"{indexDay}");
                indexDay++;
            }
            else
            {
                Numbersday.Add("");
            }
        }
    }

    string getNameMonth(int numberMonth)
    {
        switch (numberMonth)
        {
            case 1:
                return "ENE";
            case 2:
                return "FEB";
            case 3:
                return "MAR";
            case 4:
                return "ABR";
            case 5:
                return "MAY";
            case 6:
                return "JUN";
            case 7:
                return "JUL";
            case 8:
                return "AGO";
            case 9:
                return "SEP";
            case 10:
                return "OCT";
            case 11:
                return "NOV";
            case 12:
                return "DIC";
            default:
                return "";
        }
    }

    void NextMonth()
    {
        if (month == 12)
            return;
        month++;
        BuildDaysCalendar(month);
        nameMonth = getNameMonth(month);
        TxtNameMonth.Text = nameMonth;
    }

    void BackMonth()
    {
        if (month == 1)
            return;
        month--;
        BuildDaysCalendar(month);
        nameMonth = getNameMonth(month);
        TxtNameMonth.Text = nameMonth;
    }

    void BtnMonthAfter_Clicked(System.Object sender, System.EventArgs e)
    {
        NextMonth();
    }

    void BtnMonthBefore_Clicked(System.Object sender, System.EventArgs e)
    {
        BackMonth();
    }

    async void ContainerDay_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var a = (Grid)sender;
        var item = (string)a.BindingContext;
        GetReminderOfDay();
    }

    async Task GetAllReminders()
    {
        // await LocalNotificationCenter.RequestNotificationPermissionAsync(); 
        IList<NotificationRequest> notifications = await LocalNotificationCenter.Current.GetPendingNotificationList();
        MyNotifications = new ObservableCollection<NotificationRequest>(notifications);

    }

    void GetReminderOfDay() {
    }
}
