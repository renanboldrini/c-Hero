using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Planet_PlanetId",
                table: "Hero");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Hero",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Planet_PlanetId",
                table: "Hero",
                column: "PlanetId",
                principalTable: "Planet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Planet_PlanetId",
                table: "Hero");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Hero",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Planet_PlanetId",
                table: "Hero",
                column: "PlanetId",
                principalTable: "Planet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
