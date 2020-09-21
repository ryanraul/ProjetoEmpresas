using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpreasAPI.Migrations
{
    public partial class ImplementandoPascalCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qual_rep_legal",
                table: "Qsa");

            migrationBuilder.DropColumn(
                name: "capital_social",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "data_situacao",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "data_situacao_especial",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "motivo_situacao",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "situacao_especial",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "ultima_atualizacao",
                table: "Empresas");

            migrationBuilder.RenameColumn(
                name: "qual",
                table: "Qsa",
                newName: "Qual");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Qsa",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "Empresas",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Empresas",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Empresas",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Empresas",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "situacao",
                table: "Empresas",
                newName: "Situacao");

            migrationBuilder.RenameColumn(
                name: "porte",
                table: "Empresas",
                newName: "Porte");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Empresas",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Empresas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "natureza_juridica",
                table: "Empresas",
                newName: "Natureza_juridica");

            migrationBuilder.RenameColumn(
                name: "municipio",
                table: "Empresas",
                newName: "Municipio");

            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "Empresas",
                newName: "Logradouro");

            migrationBuilder.RenameColumn(
                name: "fantasia",
                table: "Empresas",
                newName: "Fantasia");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Empresas",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "efr",
                table: "Empresas",
                newName: "Efr");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Empresas",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Empresas",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Empresas",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "abertura",
                table: "Empresas",
                newName: "Abertura");

            migrationBuilder.RenameColumn(
                name: "free",
                table: "Billing",
                newName: "Free");

            migrationBuilder.RenameColumn(
                name: "database",
                table: "Billing",
                newName: "Database");

            migrationBuilder.RenameColumn(
                name: "text",
                table: "AtividadesSecundaria",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "AtividadesSecundaria",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "text",
                table: "AtividadePrincipal",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "AtividadePrincipal",
                newName: "Code");

            migrationBuilder.AddColumn<string>(
                name: "QualRepLegal",
                table: "Qsa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapitalSocial",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataSituacao",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataSituacaoEspecial",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotivoSituacao",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SituacaoEspecial",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualRepLegal",
                table: "Qsa");

            migrationBuilder.DropColumn(
                name: "CapitalSocial",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "DataSituacao",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "DataSituacaoEspecial",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "MotivoSituacao",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "SituacaoEspecial",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "UltimaAtualizacao",
                table: "Empresas");

            migrationBuilder.RenameColumn(
                name: "Qual",
                table: "Qsa",
                newName: "qual");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Qsa",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Empresas",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Empresas",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Empresas",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Empresas",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Situacao",
                table: "Empresas",
                newName: "situacao");

            migrationBuilder.RenameColumn(
                name: "Porte",
                table: "Empresas",
                newName: "porte");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Empresas",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Empresas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Natureza_juridica",
                table: "Empresas",
                newName: "natureza_juridica");

            migrationBuilder.RenameColumn(
                name: "Municipio",
                table: "Empresas",
                newName: "municipio");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Empresas",
                newName: "logradouro");

            migrationBuilder.RenameColumn(
                name: "Fantasia",
                table: "Empresas",
                newName: "fantasia");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Empresas",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Efr",
                table: "Empresas",
                newName: "efr");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Empresas",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Empresas",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Empresas",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Abertura",
                table: "Empresas",
                newName: "abertura");

            migrationBuilder.RenameColumn(
                name: "Free",
                table: "Billing",
                newName: "free");

            migrationBuilder.RenameColumn(
                name: "Database",
                table: "Billing",
                newName: "database");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "AtividadesSecundaria",
                newName: "text");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "AtividadesSecundaria",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "AtividadePrincipal",
                newName: "text");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "AtividadePrincipal",
                newName: "code");

            migrationBuilder.AddColumn<string>(
                name: "qual_rep_legal",
                table: "Qsa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "capital_social",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "data_situacao",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "data_situacao_especial",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "motivo_situacao",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "situacao_especial",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ultima_atualizacao",
                table: "Empresas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
