using Microsoft.EntityFrameworkCore.Migrations;

namespace promo_code.Migrations
{
    public partial class LanLonCoordinate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordinate",
                table: "PromoCodes",
                newName: "CoordinateLon");

            migrationBuilder.AlterColumn<decimal>(
                name: "RadiusInKilometers",
                table: "PromoCodes",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "PromoCodes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "CoordinateLat",
                table: "PromoCodes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoordinateLat",
                table: "PromoCodes");

            migrationBuilder.RenameColumn(
                name: "CoordinateLon",
                table: "PromoCodes",
                newName: "Coordinate");

            migrationBuilder.AlterColumn<decimal>(
                name: "RadiusInKilometers",
                table: "PromoCodes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "PromoCodes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
