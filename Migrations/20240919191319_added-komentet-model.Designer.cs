﻿// <auto-generated />
using System;
using EdumindAkademia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EdumindAkademia.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20240919191319_added-komentet-model")]
    partial class addedkomentetmodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EdumindAkademia.Models.Kategorite", b =>
                {
                    b.Property<int>("Numri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numri"));

                    b.Property<string>("Titulli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numri");

                    b.ToTable("Kategorite");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Komentet", b =>
                {
                    b.Property<int>("Numri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numri"));

                    b.Property<DateTime>("DataKrijimit")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Eaprovuar")
                        .HasColumnType("bit");

                    b.Property<string>("Komenti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumriProduktit")
                        .HasColumnType("int");

                    b.HasKey("Numri");

                    b.HasIndex("NumriProduktit");

                    b.ToTable("Komentet");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Produktet", b =>
                {
                    b.Property<int>("Numri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numri"));

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KategoriaNumri")
                        .HasColumnType("int");

                    b.HasKey("Numri");

                    b.HasIndex("KategoriaNumri");

                    b.ToTable("Produktet");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Komentet", b =>
                {
                    b.HasOne("EdumindAkademia.Models.Produktet", "Produktet")
                        .WithMany("Komentet")
                        .HasForeignKey("NumriProduktit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produktet");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Produktet", b =>
                {
                    b.HasOne("EdumindAkademia.Models.Kategorite", "Kategoria")
                        .WithMany("Produktet")
                        .HasForeignKey("KategoriaNumri");

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Kategorite", b =>
                {
                    b.Navigation("Produktet");
                });

            modelBuilder.Entity("EdumindAkademia.Models.Produktet", b =>
                {
                    b.Navigation("Komentet");
                });
#pragma warning restore 612, 618
        }
    }
}
