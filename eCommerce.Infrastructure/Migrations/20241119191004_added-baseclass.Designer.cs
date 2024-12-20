﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Infrastructure.Data;

#nullable disable

namespace eCommerce.Infrastructure.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20241119191004_added-baseclass")]
    partial class addedbaseclass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eCommerce.Domain.Models.Kategorite", b =>
                {
                    b.Property<int>("Numri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numri"));

                    b.Property<DateTime>("KrijuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("KrijuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PerditesuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerditesuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numri");

                    b.ToTable("Kategorite");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Komentet", b =>
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

                    b.Property<DateTime>("KrijuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("KrijuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumriProduktit")
                        .HasColumnType("int");

                    b.Property<DateTime>("PerditesuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerditesuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numri");

                    b.HasIndex("NumriProduktit");

                    b.ToTable("Komentet");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Produktet", b =>
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

                    b.Property<DateTime>("KrijuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("KrijuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PerditesuarMe")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerditesuarNga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numri");

                    b.HasIndex("KategoriaNumri");

                    b.ToTable("Produktet");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Komentet", b =>
                {
                    b.HasOne("eCommerce.Domain.Models.Produktet", "Produktet")
                        .WithMany("Komentet")
                        .HasForeignKey("NumriProduktit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produktet");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Produktet", b =>
                {
                    b.HasOne("eCommerce.Domain.Models.Kategorite", "Kategoria")
                        .WithMany("Produktet")
                        .HasForeignKey("KategoriaNumri");

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Kategorite", b =>
                {
                    b.Navigation("Produktet");
                });

            modelBuilder.Entity("eCommerce.Domain.Models.Produktet", b =>
                {
                    b.Navigation("Komentet");
                });
#pragma warning restore 612, 618
        }
    }
}
