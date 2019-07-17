using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "Power",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Power_HeroId",
                table: "Power",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Power_Hero_HeroId",
                table: "Power",
                column: "HeroId",
                principalTable: "Hero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Power_Hero_HeroId",
                table: "Power");

            migrationBuilder.DropIndex(
                name: "IX_Power_HeroId",
                table: "Power");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Power");
        }
    }
}
