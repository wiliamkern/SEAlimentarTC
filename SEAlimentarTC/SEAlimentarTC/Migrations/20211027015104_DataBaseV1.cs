using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAlimentarTC.Migrations
{
    public partial class DataBaseV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodMenu",
                columns: table => new
                {
                    FoodMenuID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MenuDay = table.Column<DateTime>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfterDinner", x => x.AfterDinnerID);
                    table.ForeignKey(
                        name: "FK_AfterDinner_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AfternoonSnack",
                columns: table => new
                {
                    AfternoonSnackID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfternoonSnack", x => x.AfternoonSnackID);
                    table.ForeignKey(
                        name: "FK_AfternoonSnack_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Breakfest",
                columns: table => new
                {
                    BreakfestID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakfest", x => x.BreakfestID);
                    table.ForeignKey(
                        name: "FK_Breakfest_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dinner",
                columns: table => new
                {
                    DinnerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinner", x => x.DinnerID);
                    table.ForeignKey(
                        name: "FK_Dinner_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lunch",
                columns: table => new
                {
                    LunchID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lunch", x => x.LunchID);
                    table.ForeignKey(
                        name: "FK_Lunch_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MorningSnack",
                columns: table => new
                {
                    MorningSnackID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FoodMenuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MorningSnack", x => x.MorningSnackID);
                    table.ForeignKey(
                        name: "FK_MorningSnack_FoodMenu_FoodMenuID",
                        column: x => x.FoodMenuID,
                        principalTable: "FoodMenu",
                        principalColumn: "FoodMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AfterDinner_FoodMenuID",
                table: "AfterDinner",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_AfternoonSnack_FoodMenuID",
                table: "AfternoonSnack",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfest_FoodMenuID",
                table: "Breakfest",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_FoodMenuID",
                table: "Dinner",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_FoodMenuID",
                table: "Lunch",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MorningSnack_FoodMenuID",
                table: "MorningSnack",
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
                name: "Lunch");

            migrationBuilder.DropTable(
                name: "MorningSnack");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "FoodMenu");
        }
    }
}
