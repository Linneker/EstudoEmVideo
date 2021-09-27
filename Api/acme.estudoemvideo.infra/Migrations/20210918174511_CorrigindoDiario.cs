using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class CorrigindoDiario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Falta",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "Presenca",
                table: "Diario");

            migrationBuilder.AddColumn<bool>(
                name: "Falta",
                table: "AlunoEscolaDiario",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Presenca",
                table: "AlunoEscolaDiario",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 18, 14, 45, 10, 843, DateTimeKind.Local).AddTicks(3844),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 15, 21, 39, 41, 759, DateTimeKind.Local).AddTicks(5031));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Falta",
                table: "AlunoEscolaDiario");

            migrationBuilder.DropColumn(
                name: "Presenca",
                table: "AlunoEscolaDiario");

            migrationBuilder.AddColumn<bool>(
                name: "Falta",
                table: "Diario",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Presenca",
                table: "Diario",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 15, 21, 39, 41, 759, DateTimeKind.Local).AddTicks(5031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 18, 14, 45, 10, 843, DateTimeKind.Local).AddTicks(3844));
        }
    }
}
