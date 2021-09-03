using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class ModificandoForeingKeycriadaerrada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudoMateria_Materia_ConteudoId",
                table: "ConteudoMateria");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 24, 20, 40, 49, 826, DateTimeKind.Local).AddTicks(6992),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 15, 22, 10, 54, 91, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoMateria_MateriaId",
                table: "ConteudoMateria",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudoMateria_Materia_MateriaId",
                table: "ConteudoMateria",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudoMateria_Materia_MateriaId",
                table: "ConteudoMateria");

            migrationBuilder.DropIndex(
                name: "IX_ConteudoMateria_MateriaId",
                table: "ConteudoMateria");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 15, 22, 10, 54, 91, DateTimeKind.Local).AddTicks(5640),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 24, 20, 40, 49, 826, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudoMateria_Materia_ConteudoId",
                table: "ConteudoMateria",
                column: "ConteudoId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
