using System;
using ExploracionPaquetes.Src.Security.Interfaces;

namespace ExploracionPaquetes.Src.Security.Interfaces
{
	public class ShowTextService: ShowTextInterface
	{
		public ShowTextService()
		{
		}

        public string TextFromPlatform()
        {
            return "Hola desde Android";
        }
    }
}

