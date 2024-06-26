﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentadeCarros.Artefactos;

#nullable disable

namespace RentadeCarros.Migrations
{
    [DbContext(typeof(RentadeCarrosDBContext))]
    partial class RentadeCarrosDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentadeCarros.Artefactos.Reservaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("Fechafinalreserva")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<DateOnly?>("Fechainicioreserva")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.Property<int?>("VehiculosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.HasIndex("VehiculosId");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("RentadeCarros.Artefactos.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumTelefonico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("RentadeCarros.Artefactos.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Año")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("RentadeCarros.Artefactos.Reservaciones", b =>
                {
                    b.HasOne("RentadeCarros.Artefactos.Usuarios", "Usuarios")
                        .WithMany("Reservaciones")
                        .HasForeignKey("UsuariosId");

                    b.HasOne("RentadeCarros.Artefactos.Vehiculos", "Vehiculos")
                        .WithMany("Reservaciones")
                        .HasForeignKey("VehiculosId");

                    b.Navigation("Usuarios");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("RentadeCarros.Artefactos.Usuarios", b =>
                {
                    b.Navigation("Reservaciones");
                });

            modelBuilder.Entity("RentadeCarros.Artefactos.Vehiculos", b =>
                {
                    b.Navigation("Reservaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
