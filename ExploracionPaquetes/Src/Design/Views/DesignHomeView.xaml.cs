using ExploracionPaquetes.Src.Design.ViewModel;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class DesignHomeView : ContentPage
{
	public DesignHomeView()
	{
		InitializeComponent();
		BindingContext = new VMdesignHome();
	}
}
