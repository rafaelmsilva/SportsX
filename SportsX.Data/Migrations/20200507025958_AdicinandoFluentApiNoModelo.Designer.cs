﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsX.Data.Context;

namespace SportsX.Data.Migrations
{
    [DbContext(typeof(SportsXContext))]
    [Migration("20200507025958_AdicinandoFluentApiNoModelo")]
    partial class AdicinandoFluentApiNoModelo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsX.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Classificacao");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<Guid?>("EnderecoId");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<Guid?>("PessoaFisicaId");

                    b.Property<Guid?>("PessoaJuridicaId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PessoaFisicaId");

                    b.HasIndex("PessoaJuridicaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasMaxLength(100);

                    b.Property<string>("Cep")
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .HasMaxLength(100);

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.PessoaFisica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PessoasFisicas");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.PessoaJuridica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PessoasJuridicas");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClienteId");

                    b.Property<string>("Numero")
                        .HasMaxLength(20);

                    b.Property<int>("TipoTelefone");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("SportsX.Domain.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("SportsX.Domain.Entities.PessoaFisica", "PessoaFisica")
                        .WithMany()
                        .HasForeignKey("PessoaFisicaId");

                    b.HasOne("SportsX.Domain.Entities.PessoaJuridica", "PessoaJuridica")
                        .WithMany()
                        .HasForeignKey("PessoaJuridicaId");
                });

            modelBuilder.Entity("SportsX.Domain.Entities.Telefone", b =>
                {
                    b.HasOne("SportsX.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
