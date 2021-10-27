using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAlimentarTC.Migrations
{
    public partial class BancoV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MorningSnack",
                columns: table => new
                {
                    MorningSnackID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MorningSnackItemID = table.Column<int>(nullable: false),
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
                name: "IX_MorningSnack_FoodMenuID",
                table: "MorningSnack",
                column: "FoodMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MorningSnack");
        }
    }
}
