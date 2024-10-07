using System.ComponentModel.DataAnnotations;

namespace RestAPI.Data.Models
{
	public class Produit
	{
		[Key]
		public int Id { get; set; }
		public int CodeMonture { get; set; }
		public int RéfFms { get; set; }
		public int PrixAchatHT { get; set; }
		public int Taille { get; set; }
		public int Référance{ get; set; }
		[MaxLength(50)]
		public string Fournisseur { get; set; }
		[MaxLength(50)]
		public string Marque { get; set; }
		public int PrixVenteHT { get; set; }
		public int Marge { get; set; }
		public int PrixVenteTTC { get; set; }
		[MaxLength(50)]
		public string Matiere { get; set; }
		public int Code { get; set; }
		public int TVA { get; set; }
		public int PrixAchatNetTTC { get; set; }
		[MaxLength(50)]
		public string Forme { get; set; }

	}
}

	
