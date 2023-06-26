using System;
namespace ExploracionPaquetes.Src.Design.Models
{
	public class MdoingCard
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public List<MdetailDoingCard> ListCardsDoing { get; set; }
	}

	public class MdetailDoingCard
	{
		public int Id { get; set; }
		public int IdDoingCard { get; set; }
		public string NameDo { get; set; }
	}
}

