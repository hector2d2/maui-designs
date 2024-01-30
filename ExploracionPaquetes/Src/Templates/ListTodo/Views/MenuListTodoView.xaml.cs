using ExploracionPaquetes.Src.Templates.ListTodo.ViewModel;

namespace ExploracionPaquetes.Src.Templates.ListTodo.Views;

public partial class MenuListTodoView : ContentPage
{
    private const uint shortDuration = 250u;
    private const uint regularDuration = shortDuration * 2u;
    double translateInitMenuDrawer = 1;
    double translateEndMenuDrawer = -1000;

    public MenuListTodoView()
	{
		InitializeComponent();
		BindingContext = new VMmenuListTodo();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        MenuContent.WidthRequest = width * .7;
    }

    async Task OpenDrawer()
    {
        MenuContainer.IsVisible = true;
        _ = MenuContainer.FadeTo(1, shortDuration, Easing.SinInOut);
        await MenuContent.TranslateTo(translateInitMenuDrawer, 0, regularDuration, Easing.SinInOut);
        _ = MenuContainer.FadeTo(1, regularDuration, Easing.SinInOut);
    }

    async Task CloseDrawer()
    {
        _ = MenuContainer.FadeTo(1, shortDuration, Easing.SinInOut);
        await MenuContent.TranslateTo(translateEndMenuDrawer, 0, regularDuration, Easing.SinInOut);
        _ = MenuContainer.FadeTo(1, regularDuration, Easing.SinInOut);
        MenuContainer.IsVisible = false;
    }

    async void ImgDrawer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {        
        await OpenDrawer();
    }

    async void OutsideDrawer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await CloseDrawer();
    }

    async void BtnSelectMap_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentSelectMap.IsVisible = true;
        ContentDoMap.IsVisible = false;
        ContentWatchAdvanceUnit.IsVisible = false;
        ContentListEvidenceUnits.IsVisible = false;
        TxtTitle.Text = "Seleccionar Mapeo";
        HstackSelectMap.BackgroundColor = Colors.Red;
        TxtTitleSelectMap.TextColor = Colors.White;
        HstackDoMap.BackgroundColor = Colors.White;
        TxtDoMap.TextColor = Colors.Black;
        HstackWatchAdvanceUnit.BackgroundColor = Colors.White;
        TxtWatchAdvanceUnit.TextColor = Colors.Black;
        HstackListEvidenceUnits.BackgroundColor = Colors.White;
        TxtListEvidenceUnits.TextColor = Colors.Black;
        await CloseDrawer();
    }
    
    async void BtnDoMap_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentSelectMap.IsVisible = false;
        ContentDoMap.IsVisible = true;
        ContentWatchAdvanceUnit.IsVisible = false;
        ContentListEvidenceUnits.IsVisible = false;
        TxtTitle.Text = "Realizar Mapeo";
        HstackSelectMap.BackgroundColor = Colors.White;
        TxtTitleSelectMap.TextColor = Colors.Black;
        HstackDoMap.BackgroundColor = Colors.Red;
        TxtDoMap.TextColor = Colors.White;
        HstackWatchAdvanceUnit.BackgroundColor = Colors.White;
        TxtWatchAdvanceUnit.TextColor = Colors.Black;
        HstackListEvidenceUnits.BackgroundColor = Colors.White;
        TxtListEvidenceUnits.TextColor = Colors.Black;
        await CloseDrawer();
    }

    async void BtnWatchAdvanceUnit_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentSelectMap.IsVisible = false;
        ContentDoMap.IsVisible = false;
        ContentWatchAdvanceUnit.IsVisible = true;
        ContentListEvidenceUnits.IsVisible = false;
        TxtTitle.Text = "Visaulizar Avance de Unidad";
        HstackSelectMap.BackgroundColor = Colors.White;
        TxtTitleSelectMap.TextColor = Colors.Black;
        HstackDoMap.BackgroundColor = Colors.White;
        TxtDoMap.TextColor = Colors.Black;
        HstackWatchAdvanceUnit.BackgroundColor = Colors.Red;
        TxtWatchAdvanceUnit.TextColor = Colors.White;
        HstackListEvidenceUnits.BackgroundColor = Colors.White;
        TxtListEvidenceUnits.TextColor = Colors.Black;
        await CloseDrawer();
    }

    async void BtnListEvidenceUnits_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ContentSelectMap.IsVisible = false;
        ContentDoMap.IsVisible = false;
        ContentWatchAdvanceUnit.IsVisible = false;
        ContentListEvidenceUnits.IsVisible = true;
        TxtTitle.Text = "Listado de Evidencia de Unidades";
        HstackSelectMap.BackgroundColor = Colors.White;
        TxtTitleSelectMap.TextColor = Colors.Black;
        HstackDoMap.BackgroundColor = Colors.White;
        TxtDoMap.TextColor = Colors.Black;
        HstackWatchAdvanceUnit.BackgroundColor = Colors.White;
        TxtWatchAdvanceUnit.TextColor = Colors.Black;
        HstackListEvidenceUnits.BackgroundColor = Colors.Red;
        TxtListEvidenceUnits.TextColor = Colors.White;
        await CloseDrawer();
    }
}
