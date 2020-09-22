using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpreasAPI.Migrations
{
    public partial class CorrecaoNaturezaJuridica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Natureza_juridica",
                table: "Empresas");

            migrationBuilder.AddColumn<string>(
                name: "NaturezaJuridica",
                table: "Empresas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NaturezaJuridica",
                table: "Empresas");

            migrationBuilder.AddColumn<string>(
                name: "Natureza_juridica",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
