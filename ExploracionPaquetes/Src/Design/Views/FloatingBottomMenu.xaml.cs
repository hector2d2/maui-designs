namespace ExploracionPaquetes.Src.Design.Views;

public partial class FloatingBottomMenu : ContentPage
{
	public FloatingBottomMenu()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        BScreateMeeting.SheetHeight = height * .8;
    }

    void MenuInit_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentInit.IsVisible = true;
        ContentEvent.IsVisible = false;
        ContentFav.IsVisible = false;
        ImgMenuInit.Color = Colors.Gold;
        TxtMenuInit.TextColor = Colors.Gold;
        ImgMenuEvent.Color = Colors.White;
        TxtMenuEvent.TextColor = Colors.White;
        ImgMenuFav.Color = Colors.White;
        TxtMenuFav.TextColor = Colors.White;
    }

    void MenuEvent_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentInit.IsVisible = false;
        ContentEvent.IsVisible = true;
        ContentFav.IsVisible = false;
        ImgMenuInit.Color = Colors.White;
        TxtMenuInit.TextColor = Colors.White;
        ImgMenuEvent.Color = Colors.Gold;
        TxtMenuEvent.TextColor = Colors.Gold;
        ImgMenuFav.Color = Colors.White;
        TxtMenuFav.TextColor = Colors.White;
    }

    void MenuFav_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentInit.IsVisible = false;
        ContentEvent.IsVisible = false;
        ContentFav.IsVisible = true;
        ImgMenuInit.Color = Colors.White;
        TxtMenuInit.TextColor = Colors.White;
        ImgMenuEvent.Color = Colors.White;
        TxtMenuEvent.TextColor = Colors.White;
        ImgMenuFav.Color = Colors.Gold;
        TxtMenuFav.TextColor = Colors.Gold;
    }

    void ControlMenu_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        MenuBottom.IsVisible = !MenuBottom.IsVisible;
        ImgControlMenu.Glyph = MenuBottom.IsVisible ? "\uf070;" : "\uf06e;"; 
    }

    async void ImgCreateMeeting_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await BScreateMeeting.OpenBottomSheet();
    }
}
