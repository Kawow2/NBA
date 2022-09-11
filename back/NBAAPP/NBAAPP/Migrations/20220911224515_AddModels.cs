using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBAAPP.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTeamID = table.Column<int>(type: "int", nullable: false),
                    AwayTeamID = table.Column<int>(type: "int", nullable: false),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: false),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: false),
                    IsPostseason = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    GameID = table.Column<int>(type: "int", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    DefensiveRebound = table.Column<int>(type: "int", nullable: false),
                    OffensiveRebound = table.Column<int>(type: "int", nullable: false),
                    Assist = table.Column<int>(type: "int", nullable: false),
                    Block = table.Column<int>(type: "int", nullable: false),
                    Turnover = table.Column<int>(type: "int", nullable: false),
                    FieldGoalsAttempts = table.Column<int>(type: "int", nullable: false),
                    FieldGoalsMade = table.Column<int>(type: "int", nullable: false),
                    ThreePointerAttempts = table.Column<int>(type: "int", nullable: false),
                    ThreePointerMade = table.Column<int>(type: "int", nullable: false),
                    FreeThrowAttempts = table.Column<int>(type: "int", nullable: false),
                    FreeThrowMade = table.Column<int>(type: "int", nullable: false),
                    Minutes = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
