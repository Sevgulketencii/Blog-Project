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

            modelBuilder.Entity("EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("adSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkinda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazarStatu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

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

                    b.Property<bool>("AdminOnay")
                        .HasColumnType("bit");

                    b.Property<int>("Id")
                        .HasColumnType("int");

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

                    b.Property<int?>("YazarId")
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

                    b.Property<int?>("MesajAlici")
                        .HasColumnType("int");

                    b.Property<int?>("MesajGönderen")
                        .HasColumnType("int");

                    b.Property<bool>("MesajStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YazarlarYazarId")
                        .HasColumnType("int");

                    b.Property<int?>("YazarlarYazarId1")
                        .HasColumnType("int");

                    b.HasKey("MesajId");

                    b.HasIndex("MesajAlici");

                    b.HasIndex("MesajGönderen");

                    b.HasIndex("YazarlarYazarId");

                    b.HasIndex("YazarlarYazarId1");

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

                    b.Property<bool>("YorumStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumId");

                    b.HasIndex("MakaleId");

                    b.ToTable("YorumDb");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Makale", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kategori", "Kategori")
                        .WithMany("Makales")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AppUser", "Yazar")
                        .WithMany("Makales")
                        .HasForeignKey("YazarId");

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", "Alici")
                        .WithMany("Alıcı")
                        .HasForeignKey("MesajAlici");

                    b.HasOne("EntityLayer.Concrete.AppUser", "Gönderen")
                        .WithMany("Gonderen")
                        .HasForeignKey("MesajGönderen");

                    b.HasOne("EntityLayer.Concrete.Yazarlar", null)
                        .WithMany("Alıcı")
                        .HasForeignKey("YazarlarYazarId");

                    b.HasOne("EntityLayer.Concrete.Yazarlar", null)
                        .WithMany("Gonderen")
                        .HasForeignKey("YazarlarYazarId1");

                    b.Navigation("Alici");

                    b.Navigation("Gönderen");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppUser", b =>
                {
                    b.Navigation("Alıcı");

                    b.Navigation("Gonderen");

                    b.Navigation("Makales");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Navigation("Makales");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Makale", b =>
                {
                    b.Navigation("Yorums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazarlar", b =>
                {
                    b.Navigation("Alıcı");

                    b.Navigation("Gonderen");
                });
#pragma warning restore 612, 618
        }
    }
}
