
using System.Windows.Input;

namespace ExploracionPaquetes.Src.CustomControllers.CardMenu;
public partial class CardMenuView : ContentView
{
    //Titulo
    //Icono
    //Evento Tap
    public readonly static BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(CardMenuView),
        ""
    );

    public string Title
    {
        get => (string)GetValue(TitleProperty);
    }
    public readonly static BindableProperty IconNameProperty = BindableProperty.Create(
        nameof(IconName),
        typeof(string),
        typeof(CardMenuView),
        ""
    );

    public string IconName
    {
        get => (string)GetValue(IconNameProperty);
    }
    public readonly static BindableProperty OnTapCommandProperty = BindableProperty.Create(
        nameof(OnTapCommand),
        typeof(ICommand),
        typeof(CardMenuView)
    );

    public ICommand OnTapCommand
    {
        get => (ICommand)GetValue(OnTapCommandProperty);
    }
    public readonly static BindableProperty OnTapParameterCommandProperty = BindableProperty.Create(
        nameof(OnTapParameterCommand),
        typeof(string),
        typeof(CardMenuView)
    );

    public string OnTapParameterCommand
    {
        get => (string)GetValue(OnTapParameterCommandProperty);
    }

    public CardMenuView()
    {
        InitializeComponent();
    }
}