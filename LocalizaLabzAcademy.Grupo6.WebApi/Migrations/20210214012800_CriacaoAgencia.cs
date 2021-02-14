using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Migrations
{
    public partial class CriacaoAgencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_CheckLists_ChecListDevolucaoId",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_CheckLists_ChecListRetiradaId",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Usuarios_UsuarioId",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Alugueis",
                newName: "OperadorId");

            migrationBuilder.RenameColumn(
                name: "ChecListRetiradaId",
                table: "Alugueis",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "ChecListDevolucaoId",
                table: "Alugueis",
                newName: "CheckListRetiradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_UsuarioId",
                table: "Alugueis",
                newName: "IX_Alugueis_OperadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_ChecListRetiradaId",
                table: "Alugueis",
                newName: "IX_Alugueis_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_ChecListDevolucaoId",
                table: "Alugueis",
                newName: "IX_Alugueis_CheckListRetiradaId");

            migrationBuilder.AddColumn<string>(
                name: "UrlVeiculo",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "RegistrosUsuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValorTotal",
                table: "Alugueis",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "TotalHorasLocacao",
                table: "Alugueis",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CheckListDevolucaoId",
                table: "Alugueis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Agencias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VeiculoAgencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenciaId = table.Column<int>(type: "int", nullable: true),
                    VeiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculoAgencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeiculoAgencia_Agencias_AgenciaId",
                        column: x => x.AgenciaId,
                        principalTable: "Agencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeiculoAgencia_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_CheckListDevolucaoId",
                table: "Alugueis",
                column: "CheckListDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoAgencia_AgenciaId",
                table: "VeiculoAgencia",
                column: "AgenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoAgencia_VeiculoId",
                table: "VeiculoAgencia",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_CheckLists_CheckListDevolucaoId",
                table: "Alugueis",
                column: "CheckListDevolucaoId",
                principalTable: "CheckLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_CheckLists_CheckListRetiradaId",
                table: "Alugueis",
                column: "CheckListRetiradaId",
                principalTable: "CheckLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Usuarios_ClienteId",
                table: "Alugueis",
                column: "ClienteId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Usuarios_OperadorId",
                table: "Alugueis",
                column: "OperadorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_CheckLists_CheckListDevolucaoId",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_CheckLists_CheckListRetiradaId",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Usuarios_ClienteId",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Usuarios_OperadorId",
                table: "Alugueis");

            migrationBuilder.DropTable(
                name: "VeiculoAgencia");

            migrationBuilder.DropIndex(
                name: "IX_Alugueis_CheckListDevolucaoId",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "UrlVeiculo",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "RegistrosUsuarios");

            migrationBuilder.DropColumn(
                name: "CheckListDevolucaoId",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Agencias");

            migrationBuilder.RenameColumn(
                name: "OperadorId",
                table: "Alugueis",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Alugueis",
                newName: "ChecListRetiradaId");

            migrationBuilder.RenameColumn(
                name: "CheckListRetiradaId",
                table: "Alugueis",
                newName: "ChecListDevolucaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_OperadorId",
                table: "Alugueis",
                newName: "IX_Alugueis_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_ClienteId",
                table: "Alugueis",
                newName: "IX_Alugueis_ChecListRetiradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_CheckListRetiradaId",
                table: "Alugueis",
                newName: "IX_Alugueis_ChecListDevolucaoId");

            migrationBuilder.AlterColumn<int>(
                name: "ValorTotal",
                table: "Alugueis",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalHorasLocacao",
                table: "Alugueis",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_CheckLists_ChecListDevolucaoId",
                table: "Alugueis",
                column: "ChecListDevolucaoId",
                principalTable: "CheckLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_CheckLists_ChecListRetiradaId",
                table: "Alugueis",
                column: "ChecListRetiradaId",
                principalTable: "CheckLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Usuarios_UsuarioId",
                table: "Alugueis",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
