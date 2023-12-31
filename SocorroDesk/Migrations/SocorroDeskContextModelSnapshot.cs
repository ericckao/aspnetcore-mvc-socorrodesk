﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocorroDesk.Database;

#nullable disable

namespace SocorroDesk.Migrations
{
    [DbContext(typeof(SocorroDeskContext))]
    partial class SocorroDeskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocorroDesk.Models.Chamado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Assunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ASSUNTO");

                    b.Property<string>("Chapa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CHAPA_COLABORADOR");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_ABERTURA");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DEPARTAMENTO");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACOES");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.Property<DateTime>("UltimaAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("ULTIMA_ATUALIZAÇÃO");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("IX_ID_UNIQUE");

                    b.ToTable("TB_CHAMADOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assunto = "Suporte de Hardware",
                            Chapa = "38976",
                            DataAbertura = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1052),
                            Departamento = "Gestão Imobiliária",
                            Status = "Aguardando Atendimento",
                            UltimaAtualizacao = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1073)
                        },
                        new
                        {
                            Id = 2,
                            Assunto = "Problemas com Login e Senha",
                            Chapa = "38976",
                            DataAbertura = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1077),
                            Departamento = "Gestão Imobiliária",
                            Status = "Aguardando Atendimento",
                            UltimaAtualizacao = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1078)
                        },
                        new
                        {
                            Id = 3,
                            Assunto = "Outros",
                            Chapa = "38976",
                            DataAbertura = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1079),
                            Departamento = "Gestão Imobiliária",
                            Status = "Aguardando Atendimento",
                            UltimaAtualizacao = new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1080)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
