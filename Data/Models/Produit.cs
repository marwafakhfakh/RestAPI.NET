using System.ComponentModel.DataAnnotations;

namespace RestAPI.Data.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string CodeMonture { get; set; }
        public string RefFms { get; set; }  // Assurez-vous que c'est bien 'RefFms' et non 'Référence'
        public float PrixAchatHT { get; set; }
        public string Taille { get; set; }
        public string Referance { get; set; } // Assurez-vous que cette propriété existe
        public string Fournisseur { get; set; }
        public string Marque { get; set; }
        public float PrixVenteHT { get; set; }
        public float Marge { get; set; }
        public float PrixVenteTTC { get; set; }
        public string Matiere { get; set; }
        public string Code { get; set; }
        public float TVA { get; set; }
        public float PrixAchatNetTTC { get; set; }
        public string Forme { get; set; }
    }
}


