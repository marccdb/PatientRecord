﻿// <auto-generated />
using System;
using FichaAtendimento.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FichaAtendimento.Server.Migrations
{
    [DbContext(typeof(FichaContext))]
    [Migration("20210211000607_adjust required fields")]
    partial class adjustrequiredfields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FichaAtendimento.Shared.Model.Ficha", b =>
                {
                    b.Property<int>("idFicha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AbordagemProxSessao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CID10_DSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CondutaClinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("date");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProxTarefa")
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
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escolaridade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdadeMae")
                        .HasColumnType("int");

                    b.Property<int>("IdadePai")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReciboPara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religiao")
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
