﻿// <auto-generated />
using System;
using GrupoEstudosMusical.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrupoEstudosMusical.Data.Migrations
{
    [DbContext(typeof(GemContext))]
    partial class GemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

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

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlunoId");

                    b.Property<bool>("ComprovanteResidencia")
                        .HasColumnType("bit");

                    b.Property<bool>("Cpf")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Pendente")
                        .HasColumnType("bit");

                    b.Property<bool>("Rg")
                        .HasColumnType("bit");

                    b.Property<int>("TurmaId");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Ocorrencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlunoID");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataOcorrido")
                        .HasColumnType("date");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<int>("TurmaID");

                    b.HasKey("Id");

                    b.HasIndex("AlunoID");

                    b.HasIndex("TurmaID");

                    b.ToTable("Ocorrencias");
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
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date");

                    b.Property<int>("ModuloID");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Periodo")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorID");

                    b.Property<int>("QuantidadeAlunos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(11)")
                        .HasDefaultValue("Ativo");

                    b.Property<DateTime>("TerminoAula")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ModuloID");

                    b.HasIndex("ProfessorID");

                    b.HasIndex("Nome", "Periodo", "Semestre")
                        .IsUnique();

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Matricula", b =>
                {
                    b.HasOne("GrupoEstudosMusical.Models.Entities.Aluno", "Aluno")
                        .WithMany("Matriculas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GrupoEstudosMusical.Models.Entities.Turma", "Turma")
                        .WithMany("Matriculas")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Ocorrencia", b =>
                {
                    b.HasOne("GrupoEstudosMusical.Models.Entities.Aluno", "Aluno")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GrupoEstudosMusical.Models.Entities.Turma", "Turma")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("TurmaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GrupoEstudosMusical.Models.Entities.Turma", b =>
                {
                    b.HasOne("GrupoEstudosMusical.Models.Entities.Modulo", "Modulo")
                        .WithMany("Turmas")
                        .HasForeignKey("ModuloID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GrupoEstudosMusical.Models.Entities.Professor", "Professor")
                        .WithMany("Turmas")
                        .HasForeignKey("ProfessorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
