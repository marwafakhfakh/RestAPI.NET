using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAPI.Migrations
{
    /// <inheritdoc />
    public partial class setProduitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeMonture = table.Column<int>(type: "int", nullable: false),
                    RéfFms = table.Column<int>(type: "int", nullable: false),
                    PrixAchatHT = table.Column<int>(type: "int", nullable: false),
                    Taille = table.Column<int>(type: "int", nullable: false),
                    Référance = table.Column<int>(type: "int", nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrixVenteHT = table.Column<int>(type: "int", nullable: false),
                    Marge = table.Column<int>(type: "int", nullable: false),
                    PrixVenteTTC = table.Column<int>(type: "int", nullable: false),
                    Matiere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    TVA = table.Column<int>(type: "int", nullable: false),
                    PrixAchatNetTTC = table.Column<int>(type: "int", nullable: false),
                    Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
