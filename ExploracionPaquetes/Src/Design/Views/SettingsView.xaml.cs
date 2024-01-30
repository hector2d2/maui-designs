namespace ExploracionPaquetes.Src.Design.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
		InitializeComponent();
	}

    void GridTheme_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        SwitchTheme.IsToggled = !SwitchTheme.IsToggled;
    }
}
