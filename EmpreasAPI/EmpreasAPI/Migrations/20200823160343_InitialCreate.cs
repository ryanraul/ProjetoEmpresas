using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpreasAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(nullable: false),
                    data_situacao = table.Column<string>(nullable: true),
                    complemento = table.Column<string>(nullable: true),
                    tipo = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    situacao = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    logradouro = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    cep = table.Column<string>(nullable: true),
                    municipio = table.Column<string>(nullable: true),
                    fantasia = table.Column<string>(nullable: true),
                    porte = table.Column<string>(nullable: true),
                    abertura = table.Column<string>(nullable: true),
                    natureza_juridica = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true),
                    ultima_atualizacao = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    efr = table.Column<string>(nullable: true),
                    motivo_situacao = table.Column<string>(nullable: true),
                    situacao_especial = table.Column<string>(nullable: true),
                    data_situacao_especial = table.Column<string>(nullable: true),
                    capital_social = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtividadePrincipal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadePrincipal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadePrincipal_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtividadesSecundaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadesSecundaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadesSecundaria_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(nullable: false),
                    free = table.Column<bool>(nullable: false),
                    database = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billing_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qsa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(nullable: false),
                    qual = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    qual_rep_legal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qsa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qsa_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtividadePrincipal_EmpresaId",
                table: "AtividadePrincipal",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesSecundaria_EmpresaId",
                table: "AtividadesSecundaria",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_EmpresaId",
                table: "Billing",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qsa_EmpresaId",
                table: "Qsa",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadePrincipal");

            migrationBuilder.DropTable(
                name: "AtividadesSecundaria");

            migrationBuilder.DropTable(
                name: "Billing");

            migrationBuilder.DropTable(
                name: "Qsa");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
