using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_AspNetUsers_AppUserId",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_AspNetUsers_AppUserId1",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajAlici",
                table: "MesajDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MesajDb_YazarlarDb_MesajGönderen",
                table: "MesajDb");

            migrationBuilder.RenameColumn(
                name: "AppUserId1",
                table: "MesajDb",
                newName: "YazarlarYazarId1");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "MesajDb",
                newName: "YazarlarYazarId");

            migrationBuilder.RenameIndex(
                name: "IX_MesajDb_AppUserId1",
                table: "MesajDb",
                newName: "IX_MesajDb_YazarlarYazarId1");

            migrationBuilder.RenameIndex(
                name: "IX_MesajDb_AppUserId",
                table: "MesajDb",
                newName: "IX_MesajDb_YazarlarYazarId");

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

            migrationBuilder.RenameColumn(
                name: "YazarlarYazarId1",
                table: "MesajDb",
                newName: "AppUserId1");

            migrationBuilder.RenameColumn(
                name: "YazarlarYazarId",
                table: "MesajDb",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MesajDb_YazarlarYazarId1",
                table: "MesajDb",
                newName: "IX_MesajDb_AppUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_MesajDb_YazarlarYazarId",
                table: "MesajDb",
                newName: "IX_MesajDb_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_AspNetUsers_AppUserId",
                table: "MesajDb",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MesajDb_AspNetUsers_AppUserId1",
                table: "MesajDb",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
