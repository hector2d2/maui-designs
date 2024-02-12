using System.Collections.ObjectModel;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class IndexedStack : ContentView
{
    public static readonly BindableProperty IdMenuProperty = BindableProperty.Create(
        nameof(IdMenu),
        typeof(int),
        typeof(IndexedStack),
        0
        );

    public int IdMenu
    {
        get
        {
            int id = (int)GetValue(IdMenuProperty);
            ChangeContent(id);
            return id;
        }
        set => SetValue(IdMenuProperty, value);
    }

    public static readonly BindableProperty MenuProperty = BindableProperty.Create(
        nameof(Menu),
        typeof(ObservableCollection<Menu>),
        typeof(IndexedStack)
        );

    public ObservableCollection<Menu> Menu
    {
        get => (ObservableCollection<Menu>)GetValue(MenuProperty);
        set => SetValue(MenuProperty, value);
    }

    public IndexedStack()
    {
        InitializeComponent();
    }

    void ChangeContent(int id)
    {
        switch (id)
        {
            case 0:
                Content = new View1();
                break;
            case 1:
                Content = new View2();
                break;
            case 2:
                Content = new View3();
                break;
            default:
                Content = new View1();
                break;
        }
    }
}