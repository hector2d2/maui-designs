using System.Collections.ObjectModel;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class Calendar : ContentPage
{
    private const uint shortDuration = 250u;
    private const uint regularDuration = shortDuration * 2u;

    string nameMonth;
	DateTime currentDate = DateTime.Now;
    ObservableCollection<string> numbersday = new();
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

    public Calendar()
	{
		InitializeComponent();
        BindingContext = this;
        InitDate();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        BStasks.HeightRequest = height * .45;
        minHeightBS = height * .45;
        maxHeightBS = height * .8;
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
            if(i >= dayOfWeekInit && daysOfMonth >= indexDay)
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
                return  "FEB";                
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

    async void BStasksUp_Clicked(System.Object sender, System.EventArgs e)
    {
        BStasks.HeightRequest = maxHeightBS;
        BStasksDown.IsVisible = true;
        BStasksUp.IsVisible = false;
        _ = BStasksUp.FadeTo(1, shortDuration, Easing.SinInOut);
        await BStasks.TranslateTo(0, 0, regularDuration, Easing.SinInOut);
    }

    async void ContainerDay_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var a = (Grid)sender;
        var item = (string)a.BindingContext;
        BStasks.IsVisible = true;
        await BStasks.TranslateTo(0, 0, regularDuration, Easing.SinInOut);
    }

    void BStasksDown_Clicked(System.Object sender, System.EventArgs e)
    {
        BStasks.HeightRequest = minHeightBS;
        BStasksDown.IsVisible = false;
        BStasksUp.IsVisible = true;
        _ = BStasksUp.TranslateTo(0,0, shortDuration, Easing.SinInOut);
    }
}
