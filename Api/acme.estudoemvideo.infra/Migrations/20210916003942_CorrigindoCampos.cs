using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class CorrigindoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 15, 21, 39, 41, 759, DateTimeKind.Local).AddTicks(5031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 15, 16, 41, 11, 359, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.CreateTable(
                name: "Boletim",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlunoEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NotaAlunoMateriaProfessorId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TotalFaltas = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boletim_AlunoEscola_AlunoEscolaId",
                        column: x => x.AlunoEscolaId,
                        principalTable: "AlunoEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boletim_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boletim_NotaAlunoMateriaProfessor_NotaAlunoMateriaProfessorId",
                        column: x => x.NotaAlunoMateriaProfessorId,
                        principalTable: "NotaAlunoMateriaProfessor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boletim_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AnoLetivoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Falta = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Presenca = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diario_AnoLetivo_AnoLetivoId",
                        column: x => x.AnoLetivoId,
                        principalTable: "AnoLetivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoEscolaDiario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlunoEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DiarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoEscolaDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoEscolaDiario_AlunoEscola_AlunoEscolaId",
                        column: x => x.AlunoEscolaId,
                        principalTable: "AlunoEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoEscolaDiario_Diario_DiarioId",
                        column: x => x.DiarioId,
                        principalTable: "Diario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorEscolaDiario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DiarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorEscolaDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessorEscolaDiario_Diario_DiarioId",
                        column: x => x.DiarioId,
                        principalTable: "Diario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorEscolaDiario_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoEscolaDiario_AlunoEscolaId",
                table: "AlunoEscolaDiario",
                column: "AlunoEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoEscolaDiario_DiarioId",
                table: "AlunoEscolaDiario",
                column: "DiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_AlunoEscolaId",
                table: "Boletim",
                column: "AlunoEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_MateriaId",
                table: "Boletim",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_NotaAlunoMateriaProfessorId",
                table: "Boletim",
                column: "NotaAlunoMateriaProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_ProfessorEscolaId",
                table: "Boletim",
                column: "ProfessorEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Diario_AnoLetivoId",
                table: "Diario",
                column: "AnoLetivoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorEscolaDiario_DiarioId",
                table: "ProfessorEscolaDiario",
                column: "DiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorEscolaDiario_ProfessorEscolaId",
                table: "ProfessorEscolaDiario",
                column: "ProfessorEscolaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoEscolaDiario");

            migrationBuilder.DropTable(
                name: "Boletim");

            migrationBuilder.DropTable(
                name: "ProfessorEscolaDiario");

            migrationBuilder.DropTable(
                name: "Diario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlunoEscola",
                table: "AlunoEscola",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 15, 16, 41, 11, 359, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 15, 21, 39, 41, 759, DateTimeKind.Local).AddTicks(5031));
        }
    }
}
