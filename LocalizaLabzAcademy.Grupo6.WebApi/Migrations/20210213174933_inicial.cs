using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarroLimpo = table.Column<bool>(type: "bit", nullable: false),
                    TanqueCheio = table.Column<bool>(type: "bit", nullable: false),
                    Amassado = table.Column<bool>(type: "bit", nullable: false),
                    Arranhoes = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecosUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecosUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcasVeiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasVeiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelosVeiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelosVeiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrosUsuarios_EnderecosUsuarios_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "EnderecosUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorHora = table.Column<double>(type: "float", nullable: false),
                    CapacidadeTanqueCombustivel = table.Column<int>(type: "int", nullable: false),
                    CapacidadePortaMalas = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: true),
                    ModeloId = table.Column<int>(type: "int", nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Combustivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculos_MarcasVeiculos_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "MarcasVeiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_ModelosVeiculos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "ModelosVeiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_RegistrosUsuarios_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "RegistrosUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alugueis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    TotalHorasLocacao = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    DataRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalRetiradaId = table.Column<int>(type: "int", nullable: true),
                    ChecListRetiradaId = table.Column<int>(type: "int", nullable: true),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalDevolucaoId = table.Column<int>(type: "int", nullable: true),
                    ChecListDevolucaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alugueis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alugueis_Agencias_LocalDevolucaoId",
                        column: x => x.LocalDevolucaoId,
                        principalTable: "Agencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alugueis_Agencias_LocalRetiradaId",
                        column: x => x.LocalRetiradaId,
                        principalTable: "Agencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alugueis_CheckLists_ChecListDevolucaoId",
                        column: x => x.ChecListDevolucaoId,
                        principalTable: "CheckLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alugueis_CheckLists_ChecListRetiradaId",
                        column: x => x.ChecListRetiradaId,
                        principalTable: "CheckLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alugueis_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alugueis_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_ChecListDevolucaoId",
                table: "Alugueis",
                column: "ChecListDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_ChecListRetiradaId",
                table: "Alugueis",
                column: "ChecListRetiradaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_LocalDevolucaoId",
                table: "Alugueis",
                column: "LocalDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_LocalRetiradaId",
                table: "Alugueis",
                column: "LocalRetiradaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_UsuarioId",
                table: "Alugueis",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_VeiculoId",
                table: "Alugueis",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosUsuarios_EnderecoId",
                table: "RegistrosUsuarios",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RegistroId",
                table: "Usuarios",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MarcaId",
                table: "Veiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ModeloId",
                table: "Veiculos",
                column: "ModeloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alugueis");

            migrationBuilder.DropTable(
                name: "Agencias");

            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "RegistrosUsuarios");

            migrationBuilder.DropTable(
                name: "MarcasVeiculos");

            migrationBuilder.DropTable(
                name: "ModelosVeiculos");

            migrationBuilder.DropTable(
                name: "EnderecosUsuarios");
        }
    }
}
