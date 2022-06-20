using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCafeRio.Web.Data.Migrations
{
    public partial class _columnnameedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationSlot",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationShift",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationShift",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationSlot",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
