using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlorescerAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriaMeuJardim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeuJardim",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlantaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Notifica = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeuJardim", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeuJardim");
        }
    }
}
