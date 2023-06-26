using ExploracionPaquetes.Src.Home.Views;

namespace ExploracionPaquetes;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());
	}
}

