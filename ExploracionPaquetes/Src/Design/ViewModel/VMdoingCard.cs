using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExploracionPaquetes.Src.Design.Models;

namespace ExploracionPaquetes.Src.Design.ViewModel
{
	[ObservableObject]
	public partial class VMdoingCard
	{
        [ObservableProperty]
		ObservableCollection<MdoingCard> cards = new();

        MdetailDoingCard dragCardSelected;

        public VMdoingCard()
		{
			Cards = new ObservableCollection<MdoingCard>()
			{
				new MdoingCard()
				{
                    Id = 1,
					Title = "Goals",
					ListCardsDoing = new List<MdetailDoingCard>()
					{
						new MdetailDoingCard()
						{
                            Id = 4,
                            IdDoingCard = 1,
							NameDo = "First Goal"
						},
                        new MdetailDoingCard()
                        {
                            Id = 5,
                            IdDoingCard = 1,
                            NameDo = "Second Goal"
                        }
                    }
				},
                new MdoingCard()
                {
                    Id = 2,
                    Title = "To Do",
                    ListCardsDoing = new List<MdetailDoingCard>()
                    {
                        new MdetailDoingCard()
                        {
                            Id = 6,
                            IdDoingCard = 2,
                            NameDo = "First Task"
                        },
                        new MdetailDoingCard()
                        {
                            Id = 7,
                            IdDoingCard = 2,
                            NameDo = "Second Task"
                        }
                    }
                },
                new MdoingCard()
                {
                    Id = 3,
                    Title = "In Progress",
                    ListCardsDoing = new List<MdetailDoingCard>()
                    {
                        new MdetailDoingCard()
                        {
                            Id = 8,
                            IdDoingCard = 3,
                            NameDo = "First Progress"
                        },
                        new MdetailDoingCard()
                        {
                            Id = 9,
                            IdDoingCard = 3,
                            NameDo = "Second Progress"
                        }
                    }
                },
            };
		}

        [RelayCommand]
        void DropCard(MdoingCard detailCard2)
        {
            MdoingCard doingCard = Cards.Where(card => card.Id == dragCardSelected.IdDoingCard).FirstOrDefault();
            doingCard.ListCardsDoing.Remove(dragCardSelected);

            dragCardSelected.IdDoingCard = detailCard2.Id;

            //MdoingCard doingCard2 = Cards.Where(card => card.Id == detailCard.Id).FirstOrDefault();
            detailCard2.ListCardsDoing.Add(dragCardSelected);
            var a = Cards;
            Cards = new ObservableCollection<MdoingCard>(Cards);
        }

        [RelayCommand]
        void DragCard(MdetailDoingCard detailCard)
        {
            dragCardSelected = detailCard;
        }
	}
}

