using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Migrations
{
    public partial class _30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Power_PowerId",
                table: "Hero");

            migrationBuilder.DropTable(
                name: "Power");

            migrationBuilder.DropIndex(
                name: "IX_Hero_PowerId",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "Hero");

            migrationBuilder.AddColumn<string>(
                name: "Power1",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power2",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power3",
                table: "Hero",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Power1",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Power2",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "Power3",
                table: "Hero");

            migrationBuilder.AddColumn<int>(
                name: "PowerId",
                table: "Hero",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Power",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HeroId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Power", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Power_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hero_PowerId",
                table: "Hero",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Power_HeroId",
                table: "Power",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Power_PowerId",
                table: "Hero",
                column: "PowerId",
                principalTable: "Power",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
