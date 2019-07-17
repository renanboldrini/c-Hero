using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Hero",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Force",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId",
                table: "Hero",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SuperName",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Universe",
                table: "Hero",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hero_CategoriaId",
                table: "Hero",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Hero_PowerId",
                table: "Hero",
                column: "PowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Categoria_CategoriaId",
                table: "Hero",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Power_PowerId",
                table: "Hero",
                column: "PowerId",
                principalTable: "Power",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Categoria_CategoriaId",
                table: "Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Power_PowerId",
                table: "Hero");

            migrationBuilder.DropIndex(
                name: "IX_Hero_CategoriaId",
                table: "Hero");

            migrationBuilder.DropIndex(
                name: "IX_Hero_PowerId",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Force",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "SuperName",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Universe",
                table: "Hero");
        }
    }
}
