﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Bildirim", b =>
                {
                    b.Property<int>("BildirimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BildirimAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildirimImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BildirimStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BildirimTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("BildirimTürü")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BildirimId");

                    b.ToTable("BildirimDb");
                });

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

            modelBuilder.Entity("EntityLayer.Concrete.MailBülteni", b =>
                {
                    b.Property<int>("MailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MailId");

                    b.ToTable("MailDb");
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

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("MakaleId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("YazarId");

                    b.ToTable("MakaleDb");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.Property<int>("MesajId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MesajAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajAlici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajGönderen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajId");

                    b.ToTable("MesajDb");
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

                    b.HasOne("EntityLayer.Concrete.Yazarlar", "Yazar")
                        .WithMany()
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
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
