using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAlimentarTC.Migrations
{
    public partial class BancoV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Breakfest",
                table: "Breakfest");

            migrationBuilder.DropColumn(
                name: "MorningSnackItemID",
                table: "MorningSnack");

            migrationBuilder.DropColumn(
                name: "BreakfestItemID",
                table: "Breakfest");

            migrationBuilder.AlterColumn<int>(
                name: "BreakfestID",
                table: "Breakfest",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breakfest",
                table: "Breakfest",
                column: "BreakfestID");

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

            migrationBuilder.CreateIndex(
                name: "IX_AfterDinner_FoodMenuID",
                table: "AfterDinner",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_AfternoonSnack_FoodMenuID",
                table: "AfternoonSnack",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_FoodMenuID",
                table: "Dinner",
                column: "FoodMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_FoodMenuID",
                table: "Lunch",
                column: "FoodMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfterDinner");

            migrationBuilder.DropTable(
                name: "AfternoonSnack");

            migrationBuilder.DropTable(
                name: "Dinner");

            migrationBuilder.DropTable(
                name: "Lunch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breakfest",
                table: "Breakfest");

            migrationBuilder.AddColumn<int>(
                name: "MorningSnackItemID",
                table: "MorningSnack",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BreakfestID",
                table: "Breakfest",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BreakfestItemID",
                table: "Breakfest",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breakfest",
                table: "Breakfest",
                columns: new[] { "BreakfestID", "BreakfestItemID" });
        }
    }
}
