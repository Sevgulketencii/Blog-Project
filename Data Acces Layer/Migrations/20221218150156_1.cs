using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HakkimizdaDb",
                columns: table => new
                {
                    HakkimizdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimizdaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaImgUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaImgUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaMap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkimizdaDb", x => x.HakkimizdaId);
                });

            migrationBuilder.CreateTable(
                name: "IletisimDb",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimDb", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "KategoriDb",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriDb", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "MailDb",
                columns: table => new
                {
                    MailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailDb", x => x.MailId);
                });

            migrationBuilder.CreateTable(
                name: "YazarlarDb",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarHakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazarlarDb", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "MakaleDb",
                columns: table => new
                {
                    MakaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakaleAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MakaleStatu = table.Column<bool>(type: "bit", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    YazarlarYazarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakaleDb", x => x.MakaleId);
                    table.ForeignKey(
                        name: "FK_MakaleDb_KategoriDb_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "KategoriDb",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakaleDb_YazarlarDb_YazarlarYazarId",
                        column: x => x.YazarlarYazarId,
                        principalTable: "YazarlarDb",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YorumDb",
                columns: table => new
                {
                    YorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumStatu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MakaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YorumDb", x => x.YorumId);
                    table.ForeignKey(
                        name: "FK_YorumDb_MakaleDb_MakaleId",
                        column: x => x.MakaleId,
                        principalTable: "MakaleDb",
                        principalColumn: "MakaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MakaleDb_KategoriId",
                table: "MakaleDb",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MakaleDb_YazarlarYazarId",
                table: "MakaleDb",
                column: "YazarlarYazarId");

            migrationBuilder.CreateIndex(
                name: "IX_YorumDb_MakaleId",
                table: "YorumDb",
                column: "MakaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HakkimizdaDb");

            migrationBuilder.DropTable(
                name: "IletisimDb");

            migrationBuilder.DropTable(
                name: "MailDb");

            migrationBuilder.DropTable(
                name: "YorumDb");

            migrationBuilder.DropTable(
                name: "MakaleDb");

            migrationBuilder.DropTable(
                name: "KategoriDb");

            migrationBuilder.DropTable(
                name: "YazarlarDb");
        }
    }
}
