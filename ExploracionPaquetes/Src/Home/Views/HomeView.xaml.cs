using ExploracionPaquetes.Src.Home.ViewModel;

namespace ExploracionPaquetes.Src.Home.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
		BindingContext = new VMhome();
	}
}
