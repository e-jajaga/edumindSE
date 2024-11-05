using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relacioniProduktKategori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriaNumri",
                table: "Produktet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produktet_KategoriaNumri",
                table: "Produktet",
                column: "KategoriaNumri");

            migrationBuilder.AddForeignKey(
                name: "FK_Produktet_Kategorite_KategoriaNumri",
                table: "Produktet",
                column: "KategoriaNumri",
                principalTable: "Kategorite",
                principalColumn: "Numri");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produktet_Kategorite_KategoriaNumri",
                table: "Produktet");

            migrationBuilder.DropIndex(
                name: "IX_Produktet_KategoriaNumri",
                table: "Produktet");

            migrationBuilder.DropColumn(
                name: "KategoriaNumri",
                table: "Produktet");
        }
    }
}
