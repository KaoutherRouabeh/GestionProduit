using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class MonContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<LC> LCs{ get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Commande> Commandes { get; set; }

        public MonContext() : base(SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), @" Data Source=.\SQLExpress;initial catalog=GestioProduit; integrated security=true").Options) {

        }
    }
}
 