﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Progetto_BE_S5.Data;

#nullable disable

namespace Progetto_BE_S5.Migrations
{
    [DbContext(typeof(ProgettoContext))]
    [Migration("20250314121944_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Progetto_BE_S5.Models.Anagrafica", b =>
                {
                    b.Property<int>("IdAnagrafica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAnagrafica"));

                    b.Property<string>("CAP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Citta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodFisc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAnagrafica");

                    b.ToTable("Anagrafiche");
                });

            modelBuilder.Entity("Progetto_BE_S5.Models.TipoViolazione", b =>
                {
                    b.Property<int>("IdViolazione")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdViolazione"));

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdViolazione");

                    b.ToTable("TipiViolazione");
                });

            modelBuilder.Entity("Progetto_BE_S5.Models.Verbale", b =>
                {
                    b.Property<int>("IdVerbale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVerbale"));

                    b.Property<DateTime>("DataTrascrizioneVerbale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataViolazione")
                        .HasColumnType("datetime2");

                    b.Property<int>("DecurtamentoPunti")
                        .HasColumnType("int");

                    b.Property<int>("IdAnagrafica")
                        .HasColumnType("int");

                    b.Property<int>("IdViolazione")
                        .HasColumnType("int");

                    b.Property<decimal>("Importo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nominativo_Agente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVerbale");

                    b.HasIndex("IdAnagrafica");

                    b.HasIndex("IdViolazione");

                    b.ToTable("Verbali");
                });

            modelBuilder.Entity("Progetto_BE_S5.Models.Verbale", b =>
                {
                    b.HasOne("Progetto_BE_S5.Models.Anagrafica", "Anagrafica")
                        .WithMany()
                        .HasForeignKey("IdAnagrafica")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Progetto_BE_S5.Models.TipoViolazione", "TipoViolazione")
                        .WithMany()
                        .HasForeignKey("IdViolazione")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Anagrafica");

                    b.Navigation("TipoViolazione");
                });
#pragma warning restore 612, 618
        }
    }
}
