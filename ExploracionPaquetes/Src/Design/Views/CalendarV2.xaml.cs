namespace ExploracionPaquetes.Src.Design.Views;

public partial class CalendarV2 : ContentPage
{
    public CalendarV2()
	{
		InitializeComponent();
        BindingContext = this;
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        MenuDrawer.WidthRequest = width * .2;
        Menucontent.WidthRequest = width * .8;        
    }


}
