using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MesajGönderen",
                table: "MesajDb",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MesajAlici",
                table: "MesajDb",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MesajDb_MesajAlici",
                table: "MesajDb",
                column: "MesajAlici");

            migrationBuilder.CreateIndex(
                name: "IX_MesajDb_MesajGönderen",
                table: "MesajDb",
                column: "MesajGönderen");

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajAlici",
                table: "MesajDb",
                column: "MesajAlici",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajGönderen",
                table: "MesajDb",
                column: "MesajGönderen",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajAlici",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajGönderen",
                table: "MesajDb");

            migrationBuilder.DropIndex(
                name: "IX_MesajDb_MesajAlici",
                table: "MesajDb");

            migrationBuilder.DropIndex(
                name: "IX_MesajDb_MesajGönderen",
                table: "MesajDb");

            migrationBuilder.AlterColumn<string>(
                name: "MesajGönderen",
                table: "MesajDb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MesajAlici",
                table: "MesajDb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
