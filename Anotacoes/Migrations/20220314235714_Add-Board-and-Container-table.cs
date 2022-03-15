using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.Api.Migrations
{
    public partial class AddBoardandContainertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Tasks",
                newName: "DateProgress");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "VARCHAR(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)");

            migrationBuilder.AddColumn<Guid>(
                name: "ContainerId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Tasks",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tasks",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "DATE", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ContainerId",
                table: "Tasks",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_UserId",
                table: "Boards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_BoardId",
                table: "Containers",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Containers_ContainerId",
                table: "Tasks",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Containers_ContainerId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ContainerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "DateProgress",
                table: "Tasks",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "VARCHAR(MAX)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldNullable: true);
        }
    }
}
