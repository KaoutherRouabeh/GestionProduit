using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get;set;}
        public string Image { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<LC> Lcs { get; set; }
    }
}
