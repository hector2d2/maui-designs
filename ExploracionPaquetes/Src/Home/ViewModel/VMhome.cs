using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Design.Views;
using ExploracionPaquetes.Src.Security.Views;
using ExploracionPaquetes.Src.Templates.ListTodo.Views;
using ExploracionPaquetes.Src.Templates.SignIn.Views;

namespace ExploracionPaquetes.Src.Home.ViewModel
{
	[ObservableObject]
	public partial class VMhome
	{
		[ObservableProperty]
		ObservableCollection<Menu> menus = new ObservableCollection<Menu>(){
			  new Menu()
			{
				Id = 0,
				Title = "Seguridad",
				IconName = "\uf023",
				RouteName = "SecurityPage"
			},
			new Menu()
			{
				Id = 1,
				Title = "Diseño",
				IconName = "\uf5ac",
				RouteName = "DesignHomePage"
			},
			new Menu()
			{
				Id = 2,
				Title = "Autenticacion",
				IconName = "\uf084",
				RouteName = "AuthenticationPage"
			},
			new Menu()
			{
				Id = 3,
				Title = "Lista de cosas.",
				IconName = "\uf4da",
				RouteName = "ListThingsPage"
			},
			new Menu()
			{
				Id = 3,
				Title = "Mi Espacio Diseños",
				IconName = "\uf170",
				RouteName = "miespacio"
			},
		};

		public VMhome()
		{
		}

		[RelayCommand]
		void GoToMenuSelected(string routeName)
		{
			Shell.Current.GoToAsync($"//{routeName}");
		}
	}
}

