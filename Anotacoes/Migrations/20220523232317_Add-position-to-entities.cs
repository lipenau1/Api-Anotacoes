using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.Api.Migrations
{
    public partial class Addpositiontoentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Containers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Containers");
        }
    }
}
