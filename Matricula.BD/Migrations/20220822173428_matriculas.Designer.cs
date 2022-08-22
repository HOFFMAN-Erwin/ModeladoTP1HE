﻿// <auto-generated />
using System;
using Matricula.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Matricula.BD.Migrations
{
    [DbContext(typeof(BD1))]
    [Migration("20220822173428_matriculas")]
    partial class matriculas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomEspecialidad")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Codigo" }, "EspecialidadCodigo_UQ")
                        .IsUnique();

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("numMatricula")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex(new[] { "Dni" }, "MedicoDni_UQ")
                        .IsUnique();

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Matricula", b =>
                {
                    b.HasOne("Matricula.BD.Data.Entidades.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Matricula.BD.Data.Entidades.Medico", "Medico")
                        .WithMany("Matriculas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Medico", b =>
                {
                    b.HasOne("Matricula.BD.Data.Entidades.Especialidad", null)
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadId");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Especialidad", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Matricula.BD.Data.Entidades.Medico", b =>
                {
                    b.Navigation("Matriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
