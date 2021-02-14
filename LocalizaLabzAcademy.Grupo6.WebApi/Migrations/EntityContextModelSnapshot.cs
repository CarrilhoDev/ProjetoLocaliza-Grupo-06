﻿// <auto-generated />
using System;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CheckListDevolucaoId")
                        .HasColumnType("int");

                    b.Property<int?>("CheckListRetiradaId")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRetirada")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocalDevolucaoId")
                        .HasColumnType("int");

                    b.Property<int?>("LocalRetiradaId")
                        .HasColumnType("int");

                    b.Property<int?>("OperadorId")
                        .HasColumnType("int");

                    b.Property<double>("TotalHorasLocacao")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CheckListDevolucaoId");

                    b.HasIndex("CheckListRetiradaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LocalDevolucaoId");

                    b.HasIndex("LocalRetiradaId");

                    b.HasIndex("OperadorId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Amassado")
                        .HasColumnType("bit");

                    b.Property<bool>("Arranhoes")
                        .HasColumnType("bit");

                    b.Property<bool>("CarroLimpo")
                        .HasColumnType("bit");

                    b.Property<bool>("TanqueCheio")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CheckLists");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.VeiculoAgencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgenciaId")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("VeiculoAgencia");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.EnderecoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnderecosUsuarios");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.RegistroUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("RegistrosUsuarios");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.MarcaVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MarcasVeiculos");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.ModeloVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModelosVeiculos");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadePortaMalas")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeTanqueCombustivel")
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("Combustivel")
                        .HasColumnType("int");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int?>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlVeiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorHora")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Aluguel", b =>
                {
                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.CheckList", "CheckListDevolucao")
                        .WithMany()
                        .HasForeignKey("CheckListDevolucaoId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.CheckList", "CheckListRetirada")
                        .WithMany()
                        .HasForeignKey("CheckListRetiradaId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.Usuario", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Agencia", "LocalDevolucao")
                        .WithMany()
                        .HasForeignKey("LocalDevolucaoId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Agencia", "LocalRetirada")
                        .WithMany()
                        .HasForeignKey("LocalRetiradaId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.Usuario", "Operador")
                        .WithMany()
                        .HasForeignKey("OperadorId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("CheckListDevolucao");

                    b.Navigation("CheckListRetirada");

                    b.Navigation("Cliente");

                    b.Navigation("LocalDevolucao");

                    b.Navigation("LocalRetirada");

                    b.Navigation("Operador");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.VeiculoAgencia", b =>
                {
                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Agencia", "Agencia")
                        .WithMany("Veiculos")
                        .HasForeignKey("AgenciaId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("Agencia");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.RegistroUsuario", b =>
                {
                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.EnderecoUsuario", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.Usuario", b =>
                {
                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User.RegistroUsuario", "Registro")
                        .WithMany()
                        .HasForeignKey("RegistroId");

                    b.Navigation("Registro");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.Veiculo", b =>
                {
                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.MarcaVeiculo", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle.ModeloVeiculo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");

                    b.Navigation("Marca");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao.Agencia", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
