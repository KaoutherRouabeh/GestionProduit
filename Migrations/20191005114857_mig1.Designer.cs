﻿// <auto-generated />
using System;
using GestionProduit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionProduit.Migrations
{
    [DbContext(typeof(MonContext))]
    [Migration("20191005114857_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionProduit.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle");

                    b.HasKey("Id");

                    b.ToTable("Categoris");
                });

            modelBuilder.Entity("GestionProduit.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom");

                    b.Property<string>("Prenom");

                    b.Property<string>("Tel");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GestionProduit.Models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("DateCommade");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("GestionProduit.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommandeId");

                    b.Property<DateTime>("DateFacture");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId")
                        .IsUnique();

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("GestionProduit.Models.LC", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommandeId");

                    b.Property<int>("ProduitId");

                    b.Property<int>("qte");

                    b.HasKey("id");

                    b.HasIndex("CommandeId");

                    b.HasIndex("ProduitId");

                    b.ToTable("LC");
                });

            modelBuilder.Entity("GestionProduit.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image");

                    b.Property<string>("Libelle");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("GestionProduit.Models.Commande", b =>
                {
                    b.HasOne("GestionProduit.Models.Client", "Client")
                        .WithMany("Commandes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionProduit.Models.Facture", b =>
                {
                    b.HasOne("GestionProduit.Models.Commande", "Commade")
                        .WithOne("Facture")
                        .HasForeignKey("GestionProduit.Models.Facture", "CommandeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionProduit.Models.LC", b =>
                {
                    b.HasOne("GestionProduit.Models.Commande", "Commande")
                        .WithMany("Lcs")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GestionProduit.Models.Produit", "Produit")
                        .WithMany("Lcs")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionProduit.Models.Produit", b =>
                {
                    b.HasOne("GestionProduit.Models.Category", "Category")
                        .WithMany("Produits")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
