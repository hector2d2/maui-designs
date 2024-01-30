using ExploracionPaquetes.Src.Templates.SignIn.ViewModel;

namespace ExploracionPaquetes.Src.Templates.SignIn.Views;

public partial class SignInView : ContentPage
{
	public SignInView()
	{
		InitializeComponent();
		BindingContext = new VMsignIn();
	}
}
