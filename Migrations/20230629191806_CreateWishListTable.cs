using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlorescerAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateWishListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScientificName",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlantaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropColumn(
                name: "ScientificName",
                table: "Plantas");
        }
    }
}
