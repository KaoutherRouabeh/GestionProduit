using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionProduit.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LC_Commandes_CommandeId",
                table: "LC");

            migrationBuilder.DropForeignKey(
                name: "FK_LC_Produits_ProduitId",
                table: "LC");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categoris_CategoryId",
                table: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LC",
                table: "LC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoris",
                table: "Categoris");

            migrationBuilder.RenameTable(
                name: "LC",
                newName: "LCs");

            migrationBuilder.RenameTable(
                name: "Categoris",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_LC_ProduitId",
                table: "LCs",
                newName: "IX_LCs_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_LC_CommandeId",
                table: "LCs",
                newName: "IX_LCs_CommandeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LCs",
                table: "LCs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LCs_Commandes_CommandeId",
                table: "LCs",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LCs_Produits_ProduitId",
                table: "LCs",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LCs_Commandes_CommandeId",
                table: "LCs");

            migrationBuilder.DropForeignKey(
                name: "FK_LCs_Produits_ProduitId",
                table: "LCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LCs",
                table: "LCs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "LCs",
                newName: "LC");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categoris");

            migrationBuilder.RenameIndex(
                name: "IX_LCs_ProduitId",
                table: "LC",
                newName: "IX_LC_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_LCs_CommandeId",
                table: "LC",
                newName: "IX_LC_CommandeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LC",
                table: "LC",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoris",
                table: "Categoris",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LC_Commandes_CommandeId",
                table: "LC",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LC_Produits_ProduitId",
                table: "LC",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categoris_CategoryId",
                table: "Produits",
                column: "CategoryId",
                principalTable: "Categoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
