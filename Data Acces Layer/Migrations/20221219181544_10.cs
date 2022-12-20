using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarlarYazarId",
                table: "MakaleDb");

            migrationBuilder.DropIndex(
                name: "IX_MakaleDb_YazarlarYazarId",
                table: "MakaleDb");

            migrationBuilder.DropColumn(
                name: "YazarlarYazarId",
                table: "MakaleDb");

            migrationBuilder.AddColumn<int>(
                name: "Puan",
                table: "MakaleDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MakaleDb_YazarId",
                table: "MakaleDb",
                column: "YazarId");

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb",
                column: "YazarId",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropIndex(
                name: "IX_MakaleDb_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropColumn(
                name: "Puan",
                table: "MakaleDb");

            migrationBuilder.AddColumn<int>(
                name: "YazarlarYazarId",
                table: "MakaleDb",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MakaleDb_YazarlarYazarId",
                table: "MakaleDb",
                column: "YazarlarYazarId");

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarlarYazarId",
                table: "MakaleDb",
                column: "YazarlarYazarId",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
