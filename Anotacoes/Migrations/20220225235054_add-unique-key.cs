using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.Api.Migrations
{
    public partial class adduniquekey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_AnexoId",
                table: "Attachments",
                column: "AnexoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_AnexoId",
                table: "Attachments");
        }
    }
}
