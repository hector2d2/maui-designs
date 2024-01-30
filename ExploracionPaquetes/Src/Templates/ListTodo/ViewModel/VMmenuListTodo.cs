using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Templates.ListTodo.Views;

namespace ExploracionPaquetes.Src.Templates.ListTodo.ViewModel
{
	[ObservableObject]
	public partial class VMmenuListTodo
	{
		[ObservableProperty]
		bool isDrawerVisible;

		[RelayCommand]
		public void OpenDrawer()
		{
			IsDrawerVisible = true;
        }

        [RelayCommand]
        void CloseDrawer()
        {
            IsDrawerVisible = false;
        }

		[RelayCommand]
		void GoToListToDo()
		{
            Application.Current.MainPage.Navigation.PushAsync(new ListTodoView());
        }
    }
}

