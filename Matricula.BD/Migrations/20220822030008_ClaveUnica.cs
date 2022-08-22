using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matricula.BD.Migrations
{
    public partial class ClaveUnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "MedicoDni_UQ",
                table: "Medicos",
                column: "Dni",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EspecialidadCodigo_UQ",
                table: "Especialidades",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "MedicoDni_UQ",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "EspecialidadCodigo_UQ",
                table: "Especialidades");
        }
    }
}
