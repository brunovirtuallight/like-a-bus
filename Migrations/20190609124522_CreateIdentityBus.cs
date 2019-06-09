using Microsoft.EntityFrameworkCore.Migrations;

namespace bus.Migrations
{
    public partial class CreateIdentityBus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Bus_Name = table.Column<string>(nullable: true),
                    Bus_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bus_Route",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Route_Short = table.Column<string>(nullable: true),
                    Bus_No = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus_Route", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bus");

            migrationBuilder.DropTable(
                name: "Bus_Route");
        }
    }
}
