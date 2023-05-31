using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlorescerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appeal",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Avaibility",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "AvaibleSizesPot",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Bearing",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "BloomingSeason",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Categorie",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Climat",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "ColorOfBloom",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "ColorOfLeaf",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Desease",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "HeightAtPurchase",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "HeightPotential",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Insect",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "LatinName",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "LightIdeal",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "LightTolered",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "OtherName",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Perfume",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "PotDiameter",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Pruning",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "TemperatureMax",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "TemperatureMin",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Use",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "Watering",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "WidthAtPurchase",
                table: "Plantas");

            migrationBuilder.RenameColumn(
                name: "Zone",
                table: "Plantas",
                newName: "Irrigation");

            migrationBuilder.RenameColumn(
                name: "WidthPotential",
                table: "Plantas",
                newName: "Climate");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Growth",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Luminosity",
                table: "Plantas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Luminosity",
                table: "Plantas");

            migrationBuilder.RenameColumn(
                name: "Irrigation",
                table: "Plantas",
                newName: "Zone");

            migrationBuilder.RenameColumn(
                name: "Climate",
                table: "Plantas",
                newName: "WidthPotential");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Plantas",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Growth",
                table: "Plantas",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "Plantas",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AddColumn<string>(
                name: "Appeal",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avaibility",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvaibleSizesPot",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bearing",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloomingSeason",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categorie",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Climat",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorOfBloom",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorOfLeaf",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desease",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightAtPurchase",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeightPotential",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Insect",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LatinName",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LightIdeal",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LightTolered",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherName",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Perfume",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PotDiameter",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pruning",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Style",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemperatureMax",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TemperatureMin",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Use",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Watering",
                table: "Plantas",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WidthAtPurchase",
                table: "Plantas",
                type: "varchar",
                nullable: false,
                defaultValue: "");
        }
    }
}
