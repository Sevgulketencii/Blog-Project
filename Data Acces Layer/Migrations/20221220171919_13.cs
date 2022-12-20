using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BildirimDb",
                columns: table => new
                {
                    BildirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BildirimTürü = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BildirimStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BildirimDb", x => x.BildirimId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BildirimDb");
        }
    }
}
