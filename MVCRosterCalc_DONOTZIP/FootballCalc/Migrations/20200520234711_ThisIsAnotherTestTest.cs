using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballCalc.Migrations
{
    public partial class ThisIsAnotherTestTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_players",
                table: "players");

            migrationBuilder.RenameTable(
                name: "players",
                newName: "player");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_Of_Birth",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "player",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "player",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PlayerPosition",
                table: "player",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RosterID",
                table: "player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_player",
                table: "player",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_player",
                table: "player");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "player");

            migrationBuilder.DropColumn(
                name: "PlayerPosition",
                table: "player");

            migrationBuilder.DropColumn(
                name: "RosterID",
                table: "player");

            migrationBuilder.RenameTable(
                name: "player",
                newName: "players");

            migrationBuilder.AlterColumn<string>(
                name: "Date_Of_Birth",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "players",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_players",
                table: "players",
                column: "PlayerName");
        }
    }
}
