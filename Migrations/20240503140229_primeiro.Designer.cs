﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Sprint2.Persistence;

#nullable disable

namespace Sprint2.Migrations
{
    [DbContext(typeof(OracleDbContext))]
    [Migration("20240503140229_primeiro")]
    partial class primeiro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sprint2.Models.Cadastro", b =>
                {
                    b.Property<int>("Id_cadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cadastro"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id_cadastro");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("Sprint2.Models.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cliente"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("NVARCHAR2(11)");

                    b.Property<DateTime>("Data_nascimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id_cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sprint2.Models.Conta", b =>
                {
                    b.Property<int>("Id_conta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_conta"));

                    b.Property<int>("Id_cadastro")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id_conta");

                    b.HasIndex("Id_cadastro");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Sprint2.Models.FeedbackCliente", b =>
                {
                    b.Property<int>("Id_feedback")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_feedback"));

                    b.Property<int>("Avaliacao")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ClienteId_cliente")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<DateTime>("Data_feedback")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id_feedback");

                    b.HasIndex("ClienteId_cliente");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Sprint2.Models.InteracaoCliente", b =>
                {
                    b.Property<int>("Id_interacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_interacao"));

                    b.Property<string>("Canal")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ClienteId_cliente")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("Data_interacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id_interacao");

                    b.HasIndex("ClienteId_cliente");

                    b.ToTable("Interacoes");
                });

            modelBuilder.Entity("Sprint2.Models.Login", b =>
                {
                    b.Property<int>("Id_login")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_login"));

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id_login");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Sprint2.Models.ResultadoIa", b =>
                {
                    b.Property<int>("Id_resultadoIa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_resultadoIa"));

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Tipo_analise")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id_resultadoIa");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("Sprint2.Models.Conta", b =>
                {
                    b.HasOne("Sprint2.Models.Cadastro", "DadosCadastro")
                        .WithMany()
                        .HasForeignKey("Id_cadastro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DadosCadastro");
                });

            modelBuilder.Entity("Sprint2.Models.FeedbackCliente", b =>
                {
                    b.HasOne("Sprint2.Models.Cliente", "Cliente")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ClienteId_cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sprint2.Models.InteracaoCliente", b =>
                {
                    b.HasOne("Sprint2.Models.Cliente", "Cliente")
                        .WithMany("Interacoes")
                        .HasForeignKey("ClienteId_cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sprint2.Models.Cliente", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Interacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
