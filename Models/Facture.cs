using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime DateFacture { get; set; }
        public Commande Commade { get; set; }
        public int CommandeId { get; set; }
    }
}
