﻿// <auto-generated />
using System;
using EmpreasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmpreasAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200827130038_LocalDb")]
    partial class LocalDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmpreasAPI.Models.AtividadePrincipal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("AtividadePrincipal");
                });

            modelBuilder.Entity("EmpreasAPI.Models.AtividadesSecundaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("AtividadesSecundaria");
                });

            modelBuilder.Entity("EmpreasAPI.Models.Billing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<bool>("database")
                        .HasColumnType("bit");

                    b.Property<bool>("free")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId")
                        .IsUnique();

                    b.ToTable("Billing");
                });

            modelBuilder.Entity("EmpreasAPI.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("abertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("capital_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_situacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_situacao_especial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("efr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motivo_situacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("natureza_juridica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("porte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacao_especial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ultima_atualizacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("EmpreasAPI.Models.Qsa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qual_rep_legal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Qsa");
                });

            modelBuilder.Entity("EmpreasAPI.Models.AtividadePrincipal", b =>
                {
                    b.HasOne("EmpreasAPI.Models.Empresa", null)
                        .WithMany("Atividade_principal")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpreasAPI.Models.AtividadesSecundaria", b =>
                {
                    b.HasOne("EmpreasAPI.Models.Empresa", null)
                        .WithMany("atividades_secundarias")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpreasAPI.Models.Billing", b =>
                {
                    b.HasOne("EmpreasAPI.Models.Empresa", null)
                        .WithOne("billing")
                        .HasForeignKey("EmpreasAPI.Models.Billing", "EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpreasAPI.Models.Qsa", b =>
                {
                    b.HasOne("EmpreasAPI.Models.Empresa", null)
                        .WithMany("qsa")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
