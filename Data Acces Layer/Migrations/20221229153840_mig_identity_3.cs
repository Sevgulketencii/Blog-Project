using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_identity_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_AspNetUsers_AppUserId",
                table: "MakaleDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropIndex(
                name: "IX_MakaleDb_AppUserId",
                table: "MakaleDb");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "MakaleDb");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_AspNetUsers_YazarId",
                table: "MakaleDb",
                column: "YazarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MakaleDb_AspNetUsers_YazarId",
                table: "MakaleDb");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MakaleDb");

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "MakaleDb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "MakaleDb",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MakaleDb_AppUserId",
                table: "MakaleDb",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_AspNetUsers_AppUserId",
                table: "MakaleDb",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MakaleDb_YazarlarDb_YazarId",
                table: "MakaleDb",
                column: "YazarId",
                principalTable: "YazarlarDb",
                principalColumn: "YazarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
