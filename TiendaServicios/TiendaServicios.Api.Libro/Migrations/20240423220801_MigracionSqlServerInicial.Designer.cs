﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaServicios.Api.Libro.Persistencia;

namespace TiendaServicios.Api.Libro.Migrations
{
    [DbContext(typeof(ContextoLibreria))]
    [Migration("20240423220801_MigracionSqlServerInicial")]
    partial class MigracionSqlServerInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TiendaServicios.Api.Libro.Modelo.LibreriaMaterial", b =>
                {
                    b.Property<Guid?>("LibreriaMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AutorLibro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibreriaMaterialId");

                    b.ToTable("libreriaMaterial");
                });
#pragma warning restore 612, 618
        }
    }
}
