using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlorescerAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Categorie = table.Column<string>(type: "varchar", nullable: true),
                    Desease = table.Column<string>(type: "varchar", nullable: true),
                    Img = table.Column<string>(type: "varchar", nullable: true),
                    Use = table.Column<string>(type: "varchar", nullable: false),
                    LatinName = table.Column<string>(type: "varchar", nullable: true),
                    Insect = table.Column<string>(type: "varchar", nullable: false),
                    Avaibility = table.Column<string>(type: "varchar", nullable: true),
                    Style = table.Column<string>(type: "varchar", nullable: true),
                    Bearing = table.Column<string>(type: "varchar", nullable: true),
                    LightTolered = table.Column<string>(type: "varchar", nullable: true),
                    HeightAtPurchase = table.Column<string>(type: "varchar", nullable: false),
                    LightIdeal = table.Column<string>(type: "varchar", nullable: true),
                    WidthAtPurchase = table.Column<string>(type: "varchar", nullable: false),
                    Appeal = table.Column<string>(type: "varchar", nullable: true),
                    Perfume = table.Column<string>(type: "varchar", nullable: true),
                    Growth = table.Column<string>(type: "varchar", nullable: true),
                    WidthPotential = table.Column<string>(type: "varchar", nullable: false),
                    Name = table.Column<string>(type: "varchar", nullable: false),
                    Pruning = table.Column<string>(type: "varchar", nullable: true),
                    Family = table.Column<string>(type: "varchar", nullable: true),
                    HeightPotential = table.Column<string>(type: "varchar", nullable: false),
                    Origin = table.Column<string>(type: "varchar", nullable: true),
                    Description = table.Column<string>(type: "varchar", nullable: true),
                    TemperatureMax = table.Column<string>(type: "varchar", nullable: false),
                    BloomingSeason = table.Column<string>(type: "varchar", nullable: true),
                    Url = table.Column<string>(type: "varchar", nullable: true),
                    ColorOfLeaf = table.Column<string>(type: "varchar", nullable: false),
                    Watering = table.Column<string>(type: "varchar", nullable: true),
                    ColorOfBloom = table.Column<string>(type: "varchar", nullable: true),
                    Zone = table.Column<string>(type: "varchar", nullable: false),
                    AvaibleSizesPot = table.Column<string>(type: "varchar", nullable: true),
                    OtherName = table.Column<string>(type: "varchar", nullable: true),
                    TemperatureMin = table.Column<string>(type: "varchar", nullable: false),
                    PotDiameter = table.Column<string>(type: "varchar", nullable: false),
                    Climat = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plantas");
        }
    }
}
