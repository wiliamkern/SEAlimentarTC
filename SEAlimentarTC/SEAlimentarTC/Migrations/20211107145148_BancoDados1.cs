using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAlimentarTC.Migrations
{
    public partial class BancoDados1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodMenu",
                columns: table => new
                {
                    FoodMenuID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    TotalKcal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMenu", x => x.FoodMenuID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Height = table.Column<decimal>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    Imc = table.Column<decimal>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ReceiveAlerts = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "AfterDinner",
                columns: table => new
                {
                    AfterDinnerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfterDinner", x => new { x.FoodMenuID, x.AfterDinnerID });
                    table.ForeignKey(
                        name: "FK_AfterDinner_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AfternoonSnack",
                columns: table => new
                {
                    AfternoonSnackID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfternoonSnack", x => new { x.FoodMenuID, x.AfternoonSnackID });
                    table.ForeignKey(
                        name: "FK_AfternoonSnack_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Breakfest",
                columns: table => new
                {
                    BreakfestID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakfest", x => new { x.FoodMenuID, x.BreakfestID });
                    table.ForeignKey(
                        name: "FK_Breakfest_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dinner",
                columns: table => new
                {
                    DinnerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinner", x => new { x.FoodMenuID, x.DinnerID });
                    table.ForeignKey(
                        name: "FK_Dinner_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMenuHistory",
                columns: table => new
                {
                    FoodMenuHistoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    MenuDay = table.Column<DateTime>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    TotalKcal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMenuHistory", x => x.FoodMenuHistoryID);
                    table.ForeignKey(
                        name: "FK_FoodMenuHistory_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lunch",
                columns: table => new
                {
                    LunchID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lunch", x => new { x.FoodMenuID, x.LunchID });
                    table.ForeignKey(
                        name: "FK_Lunch_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MorningSnack",
                columns: table => new
                {
                    MorningSnackID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodMenuID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MorningSnack", x => new { x.FoodMenuID, x.MorningSnackID });
                    table.ForeignKey(
                        name: "FK_MorningSnack_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMenuHistory_FoodMenuID",
                table: "FoodMenuHistory",
                column: "FoodMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfterDinner");

            migrationBuilder.DropTable(
                name: "AfternoonSnack");

            migrationBuilder.DropTable(
                name: "Breakfest");

            migrationBuilder.DropTable(
                name: "Dinner");

            migrationBuilder.DropTable(
                name: "FoodMenuHistory");

            migrationBuilder.DropTable(
                name: "Lunch");

            migrationBuilder.DropTable(
                name: "MorningSnack");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "FoodMenu");

            migrationBuilder.DropTable(
                name: "__EFMigrationHistory");
        }
    }
}
