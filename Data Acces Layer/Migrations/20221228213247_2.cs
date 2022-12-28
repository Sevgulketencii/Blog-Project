using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajAlici",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajGönderen",
                table: "MesajDb");

            migrationBuilder.AddColumn<int>(
                name: "YazarlarYazarId",
                table: "MesajDb",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YazarlarYazarId1",
                table: "MesajDb",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "MakaleDb",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MakaleDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "YazarHakkinda",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MesajDb_YazarlarYazarId",
                table: "MesajDb",
                column: "YazarlarYazarId");

            migrationBuilder.CreateIndex(
                name: "IX_MesajDb_YazarlarYazarId1",
                table: "MesajDb",
                column: "YazarlarYazarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_AspNetUsers_YazarId",
                table: "MakaleDb",
                column: "YazarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_AspNetUsers_MesajAlici",
                table: "MesajDb",
                column: "MesajAlici",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_AspNetUsers_MesajGönderen",
                table: "MesajDb",
                column: "MesajGönderen",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_YazarlarDb_YazarlarYazarId",
                table: "MesajDb",
                column: "YazarlarYazarId",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_YazarlarDb_YazarlarYazarId1",
                table: "MesajDb",
                column: "YazarlarYazarId1",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_AspNetUsers_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_AspNetUsers_MesajAlici",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_AspNetUsers_MesajGönderen",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_YazarlarYazarId",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_YazarlarYazarId1",
                table: "MesajDb");

            migrationBuilder.DropIndex(
                name: "IX_MesajDb_YazarlarYazarId",
                table: "MesajDb");

            migrationBuilder.DropIndex(
                name: "IX_MesajDb_YazarlarYazarId1",
                table: "MesajDb");

            migrationBuilder.DropColumn(
                name: "YazarlarYazarId",
                table: "MesajDb");

            migrationBuilder.DropColumn(
                name: "YazarlarYazarId1",
                table: "MesajDb");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MakaleDb");

            migrationBuilder.DropColumn(
                name: "YazarHakkinda",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "MakaleDb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb",
                column: "YazarId",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Cascade);

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
    }
}
