using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    CodeMonture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefFms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixAchatHT = table.Column<float>(type: "real", nullable: false),
                    Taille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixVenteHT = table.Column<float>(type: "real", nullable: false),
                    Marge = table.Column<float>(type: "real", nullable: false),
                    PrixVenteTTC = table.Column<float>(type: "real", nullable: false),
                    Matiere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TVA = table.Column<float>(type: "real", nullable: false),
                    PrixAchatNetTTC = table.Column<float>(type: "real", nullable: false),
                    Forme = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
