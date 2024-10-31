using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedkomentetmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komentet",
                columns: table => new
                {
                    Numri = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Komenti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eaprovuar = table.Column<bool>(type: "bit", nullable: false),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumriProduktit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentet", x => x.Numri);
                    table.ForeignKey(
                        name: "FK_Komentet_Produktet_NumriProduktit",
                        column: x => x.NumriProduktit,
                        principalTable: "Produktet",
                        principalColumn: "Numri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentet_NumriProduktit",
                table: "Komentet",
                column: "NumriProduktit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentet");
        }
    }
}
