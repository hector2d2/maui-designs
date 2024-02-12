using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploracionPaquetes.Src.Design.Messengers
{
    public class MenuViewsMessenger : ValueChangedMessage<int>
    {
        public MenuViewsMessenger(int value) : base(value)
        {
        }
    }
}
