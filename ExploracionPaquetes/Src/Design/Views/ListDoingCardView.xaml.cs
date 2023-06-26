using ExploracionPaquetes.Src.Design.ViewModel;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class ListDoingCardView : ContentPage
{
	public ListDoingCardView()
	{
		InitializeComponent();
        BindingContext = new VMdoingCard();
	}
}
