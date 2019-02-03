﻿// <auto-generated />
using System;
using GrupoEstudosMusical.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrupoEstudosMusical.Data.Migrations
{
    [DbContext(typeof(GemContext))]
    [Migration("20190203125513_TabelaDeProfessores")]
    partial class TabelaDeProfessores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Celular")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rg")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Rg")
                        .IsUnique();

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Celular")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(180)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });
#pragma warning restore 612, 618
        }
    }
}
