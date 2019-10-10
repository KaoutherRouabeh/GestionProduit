using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class LC
    {
        public int id { get; set; }
        public Produit Produit { get; set; }
        public Commande Commande { get; set; }
        public int ProduitId { get; set; }
        public int CommandeId { get; set; }
        public int qte { get; set; }
    }
}
