using ExploracionPaquetes.Src.Design.ViewModel;

namespace ExploracionPaquetes.Src.Design.Views;
public partial class BottomAppBarView : ContentPage
{
   
    public BottomAppBarView()
    {
        BindingContext = new VMBottomAppBar();
        InitializeComponent();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        VMBottomAppBar vMBottomAppBar = (VMBottomAppBar)BindingContext;
        vMBottomAppBar.SizeWidthBottomAppBar = width / 3;
    }
}