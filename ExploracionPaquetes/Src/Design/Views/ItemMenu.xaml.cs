using CommunityToolkit.Mvvm.Messaging;
using ExploracionPaquetes.Src.Design.Messengers;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class ItemMenu : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
        nameof(Name),
        typeof(string),
        typeof(ItemMenu),
        ""
        );

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public static readonly BindableProperty IconNameProperty = BindableProperty.Create(
        nameof(IconName),
        typeof(string),
        typeof(ItemMenu),
        ""
        );

    public string IconName
    {
        get => (string)GetValue(IconNameProperty);
        set => SetValue(IconNameProperty, value);
    }

    public static readonly BindableProperty IdMenuProperty = BindableProperty.Create(
       nameof(IdMenu),
       typeof(int),
       typeof(ItemMenu),
       0
       );

    public int IdMenu
    {
        get => (int)GetValue(IdMenuProperty);
        set => SetValue(IdMenuProperty, value);
    }

    public ItemMenu()
    {
        InitializeComponent();
    }

    private void Menu_Tapped(object sender, TappedEventArgs e)
    {
        WeakReferenceMessenger.Default.Send<MenuViewsMessenger>(new MenuViewsMessenger(IdMenu));
    }
}