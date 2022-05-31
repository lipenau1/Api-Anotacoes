using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.Api.Migrations
{
    public partial class RemoveLabelContainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Containers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Containers",
                type: "VARCHAR(100)",
                nullable: true);
        }
    }
}
