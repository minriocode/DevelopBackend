using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCafeRio.Web.Data.Migrations
{
    public partial class reservationentityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPerson = table.Column<int>(nullable: false),
                    ExpectedDate = table.Column<DateTime>(nullable: false),
                    ContactNo = table.Column<string>(nullable: true),
                    ReservationSlot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
