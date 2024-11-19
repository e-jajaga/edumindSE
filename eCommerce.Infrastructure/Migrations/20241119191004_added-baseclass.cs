using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedbaseclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "KrijuarMe",
                table: "Produktet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KrijuarNga",
                table: "Produktet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PerditesuarMe",
                table: "Produktet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PerditesuarNga",
                table: "Produktet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KrijuarMe",
                table: "Komentet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KrijuarNga",
                table: "Komentet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PerditesuarMe",
                table: "Komentet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PerditesuarNga",
                table: "Komentet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KrijuarMe",
                table: "Kategorite",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KrijuarNga",
                table: "Kategorite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PerditesuarMe",
                table: "Kategorite",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PerditesuarNga",
                table: "Kategorite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KrijuarMe",
                table: "Produktet");

            migrationBuilder.DropColumn(
                name: "KrijuarNga",
                table: "Produktet");

            migrationBuilder.DropColumn(
                name: "PerditesuarMe",
                table: "Produktet");

            migrationBuilder.DropColumn(
                name: "PerditesuarNga",
                table: "Produktet");

            migrationBuilder.DropColumn(
                name: "KrijuarMe",
                table: "Komentet");

            migrationBuilder.DropColumn(
                name: "KrijuarNga",
                table: "Komentet");

            migrationBuilder.DropColumn(
                name: "PerditesuarMe",
                table: "Komentet");

            migrationBuilder.DropColumn(
                name: "PerditesuarNga",
                table: "Komentet");

            migrationBuilder.DropColumn(
                name: "KrijuarMe",
                table: "Kategorite");

            migrationBuilder.DropColumn(
                name: "KrijuarNga",
                table: "Kategorite");

            migrationBuilder.DropColumn(
                name: "PerditesuarMe",
                table: "Kategorite");

            migrationBuilder.DropColumn(
                name: "PerditesuarNga",
                table: "Kategorite");
        }
    }
}
