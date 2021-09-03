using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class Criando_TurmaMateria_E_MateriaProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 27, 8, 59, 42, 902, DateTimeKind.Local).AddTicks(3804),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 27, 8, 13, 47, 135, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.CreateTable(
                name: "MateriaProfessorEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaProfessorEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MateriaProfessorEscola_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaProfessorEscola_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurmaMateria",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmaMateria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmaMateria_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaMateria_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaProfessorEscola_MateriaId",
                table: "MateriaProfessorEscola",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaProfessorEscola_ProfessorEscolaId",
                table: "MateriaProfessorEscola",
                column: "ProfessorEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaMateria_MateriaId",
                table: "TurmaMateria",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaMateria_TurmaId",
                table: "TurmaMateria",
                column: "TurmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MateriaProfessorEscola");

            migrationBuilder.DropTable(
                name: "TurmaMateria");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 27, 8, 13, 47, 135, DateTimeKind.Local).AddTicks(2559),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 27, 8, 59, 42, 902, DateTimeKind.Local).AddTicks(3804));
        }
    }
}
