using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ExploracionPaquetes.Src.Design.Messengers;
using ExploracionPaquetes.Src.Design.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploracionPaquetes.Src.Design.ViewModel
{
    [ObservableObject]
    public partial class VMBottomAppBar : IRecipient<MenuViewsMessenger>
    {
        [ObservableProperty]
        ContentView content = new View1();

        [ObservableProperty]
        ObservableCollection<Menu> menus = new ObservableCollection<Menu>()
        {
            new Menu()
            {
                Id = 0,
                Title = "view 1",
                IconName = "View 1"
            },
            new Menu()
            {
                Id = 1,
                Title = "view 2",
                IconName = "View 2"
            },
            new Menu()
            {
                Id = 2,
                Title = "view 3",
                IconName = "View 3"
            },
        };

        [ObservableProperty]
        int idCurrentIndex = 0;

        [ObservableProperty]
        double sizeWidthBottomAppBar = 0;

        public VMBottomAppBar()
        {
            WeakReferenceMessenger.Default.Register(this);
        }

        public void Receive(MenuViewsMessenger message)
        {
            changeIndex(message.Value);
        }

        [RelayCommand]
        void changeIndex(int index) 
        {
            IdCurrentIndex = index;
            ChangeContent(index);
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
}
