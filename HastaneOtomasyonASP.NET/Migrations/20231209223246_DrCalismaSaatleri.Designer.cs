﻿// <auto-generated />
using System;
using HastaneOtomasyonASP.NET.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HastaneOtomasyonASP.NET.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20231209223246_DrCalismaSaatleri")]
    partial class DrCalismaSaatleri
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.CalismaSaati", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DoktorId")
                        .HasColumnType("int");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoktorId");

                    b.ToTable("CalismaSaatleri");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alan")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ResimURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doktorlar");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hastalar");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Polikinlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Polikinlikler");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoktorId")
                        .HasColumnType("int");

                    b.Property<int>("HastaId")
                        .HasColumnType("int");

                    b.Property<int>("PolikinlikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoktorId");

                    b.HasIndex("HastaId");

                    b.HasIndex("PolikinlikId");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.CalismaSaati", b =>
                {
                    b.HasOne("HastaneOtomasyonASP.NET.Models.Doktor", null)
                        .WithMany("CalismaSaatleri")
                        .HasForeignKey("DoktorId");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Randevu", b =>
                {
                    b.HasOne("HastaneOtomasyonASP.NET.Models.Doktor", "Doktor")
                        .WithMany()
                        .HasForeignKey("DoktorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneOtomasyonASP.NET.Models.Hasta", "Hasta")
                        .WithMany()
                        .HasForeignKey("HastaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneOtomasyonASP.NET.Models.Polikinlik", "Polikinlik")
                        .WithMany()
                        .HasForeignKey("PolikinlikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doktor");

                    b.Navigation("Hasta");

                    b.Navigation("Polikinlik");
                });

            modelBuilder.Entity("HastaneOtomasyonASP.NET.Models.Doktor", b =>
                {
                    b.Navigation("CalismaSaatleri");
                });
#pragma warning restore 612, 618
        }
    }
}
