using ExploracionPaquetes.Src.Security.ViewModel;

namespace ExploracionPaquetes.Src.Security.Views;

public partial class SecurityHome : ContentPage
{
	public SecurityHome()
	{
		InitializeComponent();
		BindingContext = new VMsecurityHome();
	}
}
