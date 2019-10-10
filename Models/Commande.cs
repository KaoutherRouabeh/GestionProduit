using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCommade { get; set; }
        public List<LC> Lcs { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Facture Facture { get; set; }
    }
}
