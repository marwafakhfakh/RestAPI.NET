﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPI.Data;

#nullable disable

namespace RestAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241007120856_setProduitTable")]
    partial class setProduitTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestAPI.Data.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("CodeMonture")
                        .HasColumnType("int");

                    b.Property<string>("Forme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fournisseur")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Marge")
                        .HasColumnType("int");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Matiere")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PrixAchatHT")
                        .HasColumnType("int");

                    b.Property<int>("PrixAchatNetTTC")
                        .HasColumnType("int");

                    b.Property<int>("PrixVenteHT")
                        .HasColumnType("int");

                    b.Property<int>("PrixVenteTTC")
                        .HasColumnType("int");

                    b.Property<int>("RéfFms")
                        .HasColumnType("int");

                    b.Property<int>("Référance")
                        .HasColumnType("int");

                    b.Property<int>("TVA")
                        .HasColumnType("int");

                    b.Property<int>("Taille")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produits");
                });
#pragma warning restore 612, 618
        }
    }
}
