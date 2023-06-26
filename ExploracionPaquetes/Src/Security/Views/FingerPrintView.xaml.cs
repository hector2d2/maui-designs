using ExploracionPaquetes.Src.Security.ViewModel;

namespace ExploracionPaquetes.Src.Security.Views;

public partial class FingerPrintView : ContentPage
{
	public FingerPrintView()
	{
		InitializeComponent();
		BindingContext = new VMfingerPrint();
	}
}
