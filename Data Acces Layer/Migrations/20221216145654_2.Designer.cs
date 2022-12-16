﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221216145654_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Hakkimizda", b =>
                {
                    b.Property<int>("HakkimizdaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HakkimizdaAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimizdaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimizdaImgUrl1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimizdaImgUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimizdaMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimizdaStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkimizdaId");

                    b.ToTable("HakkimizdaDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Iletisim", b =>
                {
                    b.Property<int>("IletisimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IletisimAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimMesaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IletisimStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IletisimTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("IletisimId");

                    b.ToTable("IletisimDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KategoriStatu")
                        .HasColumnType("bit");

                    b.HasKey("KategoriId");

                    b.ToTable("KategoriDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Makale", b =>
                {
                    b.Property<int>("MakaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("MakaleAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakaleAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakaleBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakaleImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MakaleStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MakaleTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MakaleId");

                    b.HasIndex("KategoriId");

                    b.ToTable("MakaleDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazarlar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YazarAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarHakkinda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YazarStatu")
                        .HasColumnType("bit");

                    b.HasKey("YazarId");

                    b.ToTable("YazarlarDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MakaleId")
                        .HasColumnType("int");

                    b.Property<string>("YorumAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumStatu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumId");

                    b.HasIndex("MakaleId");

                    b.ToTable("YorumDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Makale", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kategori", "Kategori")
                        .WithMany("Makales")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Makale", "Makale")
                        .WithMany("Yorums")
                        .HasForeignKey("MakaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Makale");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Navigation("Makales");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Makale", b =>
                {
                    b.Navigation("Yorums");
                });
#pragma warning restore 612, 618
        }
    }
}
