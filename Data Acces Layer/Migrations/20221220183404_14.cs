using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MesajDb",
                columns: table => new
                {
                    MesajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajAlici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajGönderen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesajDb", x => x.MesajId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MesajDb");
        }
    }
}
