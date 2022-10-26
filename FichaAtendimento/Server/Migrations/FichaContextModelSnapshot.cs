﻿// <auto-generated />
using System;
using FichaAtendimento.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FichaAtendimento.Server.Migrations
{
    [DbContext(typeof(FichaContext))]
    partial class FichaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FichaAtendimento.Shared.Model.Ficha", b =>
                {
                    b.Property<int>("idFicha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idFicha"), 1L, 1);

                    b.Property<string>("CondutaClinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("date");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReciboEntregue")
                        .HasColumnType("bit");

                    b.Property<string>("ResumoAtendimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SessaoPaga")
                        .HasColumnType("bit");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.HasKey("idFicha");

                    b.ToTable("Fichas");
                });

            modelBuilder.Entity("FichaAtendimento.Shared.Model.Paciente", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPaciente"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReciboPara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPaciente");

                    b.ToTable("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
