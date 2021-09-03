using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class Modificando_TurmaMateriaProfessoEscola_para_TurmaProfessorEscola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TurmaMateriaProfessorEscola");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 27, 8, 13, 47, 135, DateTimeKind.Local).AddTicks(2559),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 24, 20, 40, 49, 826, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.CreateTable(
                name: "TurmaProfessorEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmaProfessorEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmaProfessorEscola_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaProfessorEscola_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TurmaProfessorEscola_ProfessorEscolaId",
                table: "TurmaProfessorEscola",
                column: "ProfessorEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaProfessorEscola_TurmaId",
                table: "TurmaProfessorEscola",
                column: "TurmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TurmaProfessorEscola");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 24, 20, 40, 49, 826, DateTimeKind.Local).AddTicks(6992),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 27, 8, 13, 47, 135, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.CreateTable(
                name: "TurmaMateriaProfessorEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmaMateriaProfessorEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmaMateriaProfessorEscola_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaMateriaProfessorEscola_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaMateriaProfessorEscola_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TurmaMateriaProfessorEscola_MateriaId",
                table: "TurmaMateriaProfessorEscola",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaMateriaProfessorEscola_ProfessorEscolaId",
                table: "TurmaMateriaProfessorEscola",
                column: "ProfessorEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaMateriaProfessorEscola_TurmaId",
                table: "TurmaMateriaProfessorEscola",
                column: "TurmaId");
        }
    }
}
