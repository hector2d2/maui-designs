using System.Collections.ObjectModel;

namespace ExploracionPaquetes.Src.Design.Views;
public partial class BottomAppBarView : ContentPage
{
    public ObservableCollection<Menu> Menus = new ObservableCollection<Menu>(){
        new Menu()
        {
            Id = 1,
            Name = "Pagina 1",
            IconName = " Icon 1"
        },
        new Menu()
        {
            Id = 2,
            Name = "Pagina 2",
            IconName = " Icon 1"
        },
        new Menu()
        {
            Id = 3,
            Name = "Pagina 3",
            IconName = " Icon 1"
        },
    };

    public BottomAppBarView()
    {
        BindingContext = this;
        InitializeComponent();
    }
}