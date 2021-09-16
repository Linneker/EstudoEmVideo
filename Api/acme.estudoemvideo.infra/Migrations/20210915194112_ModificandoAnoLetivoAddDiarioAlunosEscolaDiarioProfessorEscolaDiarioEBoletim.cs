using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class ModificandoAnoLetivoAddDiarioAlunosEscolaDiarioProfessorEscolaDiarioEBoletim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "AnoLetivo");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "AnoLetivo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "AnoLetivo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "FeriadoFixo",
                table: "AnoLetivo",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "AnoLetivo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 15, 16, 41, 11, 359, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 27, 8, 59, 42, 902, DateTimeKind.Local).AddTicks(3804));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "AnoLetivo");

            migrationBuilder.DropColumn(
                name: "Dia",
                table: "AnoLetivo");

            migrationBuilder.DropColumn(
                name: "FeriadoFixo",
                table: "AnoLetivo");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "AnoLetivo");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "AnoLetivo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 27, 8, 59, 42, 902, DateTimeKind.Local).AddTicks(3804),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 15, 16, 41, 11, 359, DateTimeKind.Local).AddTicks(2570));
        }
    }
}
