using ExploracionPaquetes.Src.Templates.ListTodo.ViewModel;

namespace ExploracionPaquetes.Src.Templates.ListTodo.Views;

public partial class ListTodoView : ContentPage
{
	public ListTodoView()
	{
		InitializeComponent();
		BindingContext = new VMlistTodo();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        BSlistTodoSection.SheetHeight = height * .9;
    }

    async void BtnMenu_Clicked(System.Object sender, System.EventArgs e)
    {
		await BSlistTodoSection.OpenBottomSheet();
    }
}