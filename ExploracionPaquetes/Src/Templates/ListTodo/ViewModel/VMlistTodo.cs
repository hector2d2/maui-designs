using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Templates.ListTodo.Models;

namespace ExploracionPaquetes.Src.Templates.ListTodo.ViewModel
{
	[ObservableObject]
	public partial class VMlistTodo
	{
		[ObservableProperty]
		ObservableCollection<TodoModel> todos = new();

        [ObservableProperty]
        bool isTodoListVisible = true;

        [ObservableProperty]
        bool isExpectationVisible;

        [ObservableProperty]
        bool isObservationsVisible;

        public VMlistTodo()
		{
			Todos = new ObservableCollection<TodoModel>()
			{
				new TodoModel()
				{
					Id = 1,
					Title = "Anuncios Luminosos: Funcionando, limpios y sin roturas.",
					IsSelected = false
				},
                new TodoModel()
                {
                    Id = 2,
                    Title = "Cristales libres de rayaduras y limpios.",
                    IsSelected = false
                },
                new TodoModel()
                {
                    Id = 3,
                    Title = "Full sheet con promociones vigentes",
                    IsSelected = false
                },
                new TodoModel()
                {
                    Id = 4,
                    Title = "Estacionamientos pintado, limpio y con señalizacion definida",
                    IsSelected = false
                },
                new TodoModel()
                {
                    Id = 5,
                    Title = "Fachada: pintada, todos limpios y in rotura",
                    IsSelected = false
                },
            };
		}

        [RelayCommand]
        void SeeTodos()
        {
            var a = Todos;
        }

        [RelayCommand]
        void SelectTodoListVisible()
        {
            IsTodoListVisible = true;
            IsExpectationVisible = false;
            IsObservationsVisible = false;
        }

        [RelayCommand]
        void SelectExpectationVisible()
        {
            IsTodoListVisible = false;
            IsExpectationVisible = true;
            IsObservationsVisible = false;
        }

        [RelayCommand]
        void SelectObservationVisible()
        {
            IsTodoListVisible = false;
            IsExpectationVisible = false;
            IsObservationsVisible = true;
        }
    }
}

