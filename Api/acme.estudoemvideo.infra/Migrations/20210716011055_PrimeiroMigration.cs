using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.estudoemvideo.infra.Migrations
{
    public partial class PrimeiroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoLetivo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    FeiradoNacional = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    FeiradoEstadual = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    FeiradoMunicipal = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    FeiradoEscolar = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DiaLetivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoLetivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NomeArquivoSalvo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    NomeArquivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Url = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: true),
                    HashArquivo = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacaoApi",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AccessKey = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    CnpjEmpresa = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacaoApi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bimestre",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bimestre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conteudo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Pais = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Rua = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Caminho = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Icone = table.Column<string>(type: "text", nullable: true),
                    Posicao = table.Column<int>(type: "int", nullable: false),
                    MenuIdPai = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieList",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NomeLista = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CaminhoLista = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, defaultValue: "~/Video/"),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    IsAprovado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRecuperacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsReprovado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametro",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: false),
                    Valor = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Editar = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pergunta",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    DataPergunta = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pergunta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    DadosModificado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    NomeArquivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Caminho = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, defaultValue: "~/Video/"),
                    EnumPopularidade = table.Column<int>(type: "int", nullable: true),
                    Visualizacao = table.Column<long>(type: "bigint", nullable: true),
                    PopularidadeEmNumero = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apostila",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Bibliografia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ArquivoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ConteudoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apostila", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apostila_Arquivo_ArquivoId",
                        column: x => x.ArquivoId,
                        principalTable: "Arquivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apostila_Conteudo_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Bibliografia = table.Column<string>(type: "text", nullable: true),
                    ArquivoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ConteudoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Arquivo_ArquivoId",
                        column: x => x.ArquivoId,
                        principalTable: "Arquivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livro_Conteudo_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    EnderecoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoEscola_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecoEscola_Escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConteudoMateria",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataAtribuicao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ConteudoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudoMateria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConteudoMateria_Conteudo_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConteudoMateria_Materia_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissaoMenu",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PermissaoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MenuId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Add = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Read = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Delete = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Update = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissaoMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissaoMenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissaoMenu_Permissao_PermissaoId",
                        column: x => x.PermissaoId,
                        principalTable: "Permissao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: true),
                    Periodo = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turma_Escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turma_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Compromisso = table.Column<string>(type: "text", nullable: true),
                    DataCompromisso = table.Column<DateTime>(type: "datetime", nullable: false),
                    Prova = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AnoLetivoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_AnoLetivo_AnoLetivoId",
                        column: x => x.AnoLetivoId,
                        principalTable: "AnoLetivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agenda_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataAlunoEscola = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 7, 15, 22, 10, 54, 91, DateTimeKind.Local).AddTicks(5640)),
                    DataMatriculaAlunoNaEscola = table.Column<DateTime>(type: "datetime", nullable: false),
                    Matricula = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoEscola_Escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoEscola_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlterarSenha = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    ContaAtiva = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: true),
                    Logado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Login = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    TermoDeAceite = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conta_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoUsuario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EnderecoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoUsuario_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecoUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    DataLog = table.Column<DateTime>(type: "datetime", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: false),
                    ObjetoJson = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: false),
                    ModificaoObjeto = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: true),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieListUsuario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Download = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    Favorito = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    MovieListId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieListUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieListUsuario_MovieList_MovieListId",
                        column: x => x.MovieListId,
                        principalTable: "MovieList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieListUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PopularidadeProfessor = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessorEscola_Escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorEscola_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TotalPerguntas = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resposta",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Relevancia = table.Column<int>(type: "int", nullable: false),
                    DataInseridaResposta = table.Column<DateTime>(type: "datetime", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PerguntaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resposta_Pergunta_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Pergunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resposta_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaVideo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    VideoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CategoriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaVideo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaVideo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieListVideo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataLigacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MovieListId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    VideoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieListVideo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieListVideo_MovieList_MovieListId",
                        column: x => x.MovieListId,
                        principalTable: "MovieList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieListVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VotoVideo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    LikeRelevancia = table.Column<long>(type: "bigint", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true),
                    QuantidadeLike = table.Column<long>(type: "bigint", nullable: false),
                    VideoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UsuarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotoVideo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VotoVideo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VotoVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurmaBimestre",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    BimestreId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmaBimestre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmaBimestre_Bimestre_BimestreId",
                        column: x => x.BimestreId,
                        principalTable: "Bimestre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaBimestre_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriaAgenda",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AgendaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MateriaAgenda_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaAgenda_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrequenciaAlunoMateria",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlunoEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AgendaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    QuantidadeFalta = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    QuantidadePresenca = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    QuantidadeFaltaJustificada = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    JustificativaFalta = table.Column<string>(type: "text", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequenciaAlunoMateria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrequenciaAlunoMateria_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FrequenciaAlunoMateria_AlunoEscola_AlunoEscolaId",
                        column: x => x.AlunoEscolaId,
                        principalTable: "AlunoEscola",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FrequenciaAlunoMateria_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TurmaAlunoEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlunoEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmaAlunoEscola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmaAlunoEscola_AlunoEscola_AlunoEscolaId",
                        column: x => x.AlunoEscolaId,
                        principalTable: "AlunoEscola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmaAlunoEscola_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissaoConta",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataAtribuicao = table.Column<DateTime>(type: "datetime", nullable: false),
                    PermissaoValida = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PermissaoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ContaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Delete = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Update = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Add = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Read = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissaoConta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissaoConta_Conta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Conta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissaoConta_Permissao_PermissaoId",
                        column: x => x.PermissaoId,
                        principalTable: "Permissao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaAlunoMateriaProfessor",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NotaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AlunoEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaAlunoMateriaProfessor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaProfessor_AlunoEscola_AlunoEscolaId",
                        column: x => x.AlunoEscolaId,
                        principalTable: "AlunoEscola",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaProfessor_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaProfessor_Nota_NotaId",
                        column: x => x.NotaId,
                        principalTable: "Nota",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaProfessor_ProfessorEscola_ProfessorEscolaId",
                        column: x => x.ProfessorEscolaId,
                        principalTable: "ProfessorEscola",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TurmaMateriaProfessorEscola",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TurmaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ProfessorEscolaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
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

            migrationBuilder.CreateTable(
                name: "PerguntaQuestionario",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataVinculo = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuestionarioId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PerguntaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RespostaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaQuestionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerguntaQuestionario_Pergunta_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Pergunta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerguntaQuestionario_Questionario_QuestionarioId",
                        column: x => x.QuestionarioId,
                        principalTable: "Questionario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerguntaQuestionario_Resposta_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Resposta",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotaAlunoMateriaConteudo",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NotaAlunoMateriaId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ConteudoId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataModificacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInativacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaAlunoMateriaConteudo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaConteudo_Conteudo_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaAlunoMateriaConteudo_NotaAlunoMateriaProfessor_NotaAluno~",
                        column: x => x.NotaAlunoMateriaId,
                        principalTable: "NotaAlunoMateriaProfessor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_AnoLetivoId",
                table: "Agenda",
                column: "AnoLetivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_UsuarioId",
                table: "Agenda",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoEscola_EscolaId",
                table: "AlunoEscola",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoEscola_UsuarioId",
                table: "AlunoEscola",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Apostila_ArquivoId",
                table: "Apostila",
                column: "ArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apostila_ConteudoId",
                table: "Apostila",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaVideo_CategoriaId",
                table: "CategoriaVideo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaVideo_VideoId",
                table: "CategoriaVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_UsuarioId",
                table: "Conta",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoMateria_ConteudoId",
                table: "ConteudoMateria",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Cep",
                table: "Endereco",
                column: "Cep",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEscola_EnderecoId",
                table: "EnderecoEscola",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEscola_EscolaId",
                table: "EnderecoEscola",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoUsuario_EnderecoId",
                table: "EnderecoUsuario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoUsuario_UsuarioId",
                table: "EnderecoUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequenciaAlunoMateria_AgendaId",
                table: "FrequenciaAlunoMateria",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequenciaAlunoMateria_AlunoEscolaId",
                table: "FrequenciaAlunoMateria",
                column: "AlunoEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequenciaAlunoMateria_MateriaId",
                table: "FrequenciaAlunoMateria",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_ArquivoId",
                table: "Livro",
                column: "ArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_ConteudoId",
                table: "Livro",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UsuarioId",
                table: "Log",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaAgenda_AgendaId",
                table: "MateriaAgenda",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaAgenda_MateriaId",
                table: "MateriaAgenda",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieListUsuario_MovieListId",
                table: "MovieListUsuario",
                column: "MovieListId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieListUsuario_UsuarioId",
                table: "MovieListUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieListVideo_MovieListId",
                table: "MovieListVideo",
                column: "MovieListId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieListVideo_VideoId",
                table: "MovieListVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaConteudo_ConteudoId",
                table: "NotaAlunoMateriaConteudo",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaConteudo_NotaAlunoMateriaId",
                table: "NotaAlunoMateriaConteudo",
                column: "NotaAlunoMateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaProfessor_AlunoEscolaId",
                table: "NotaAlunoMateriaProfessor",
                column: "AlunoEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaProfessor_MateriaId",
                table: "NotaAlunoMateriaProfessor",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaProfessor_NotaId",
                table: "NotaAlunoMateriaProfessor",
                column: "NotaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunoMateriaProfessor_ProfessorEscolaId",
                table: "NotaAlunoMateriaProfessor",
                column: "ProfessorEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaQuestionario_PerguntaId",
                table: "PerguntaQuestionario",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaQuestionario_QuestionarioId",
                table: "PerguntaQuestionario",
                column: "QuestionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaQuestionario_RespostaId",
                table: "PerguntaQuestionario",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissaoConta_ContaId",
                table: "PermissaoConta",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissaoConta_PermissaoId",
                table: "PermissaoConta",
                column: "PermissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissaoMenu_MenuId",
                table: "PermissaoMenu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissaoMenu_PermissaoId",
                table: "PermissaoMenu",
                column: "PermissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorEscola_EscolaId",
                table: "ProfessorEscola",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorEscola_UsuarioId",
                table: "ProfessorEscola",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionario_UsuarioId",
                table: "Questionario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_PerguntaId",
                table: "Resposta",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Resposta_UsuarioId",
                table: "Resposta",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_EscolaId",
                table: "Turma",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_SerieId",
                table: "Turma",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaAlunoEscola_AlunoEscolaId",
                table: "TurmaAlunoEscola",
                column: "AlunoEscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaAlunoEscola_TurmaId",
                table: "TurmaAlunoEscola",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaBimestre_BimestreId",
                table: "TurmaBimestre",
                column: "BimestreId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmaBimestre_TurmaId",
                table: "TurmaBimestre",
                column: "TurmaId");

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

            migrationBuilder.CreateIndex(
                name: "IX_VotoVideo_UsuarioId",
                table: "VotoVideo",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_VotoVideo_VideoId",
                table: "VotoVideo",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apostila");

            migrationBuilder.DropTable(
                name: "AutorizacaoApi");

            migrationBuilder.DropTable(
                name: "CategoriaVideo");

            migrationBuilder.DropTable(
                name: "ConteudoMateria");

            migrationBuilder.DropTable(
                name: "EnderecoEscola");

            migrationBuilder.DropTable(
                name: "EnderecoUsuario");

            migrationBuilder.DropTable(
                name: "FrequenciaAlunoMateria");

            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "MateriaAgenda");

            migrationBuilder.DropTable(
                name: "MovieListUsuario");

            migrationBuilder.DropTable(
                name: "MovieListVideo");

            migrationBuilder.DropTable(
                name: "NotaAlunoMateriaConteudo");

            migrationBuilder.DropTable(
                name: "Parametro");

            migrationBuilder.DropTable(
                name: "PerguntaQuestionario");

            migrationBuilder.DropTable(
                name: "PermissaoConta");

            migrationBuilder.DropTable(
                name: "PermissaoMenu");

            migrationBuilder.DropTable(
                name: "TurmaAlunoEscola");

            migrationBuilder.DropTable(
                name: "TurmaBimestre");

            migrationBuilder.DropTable(
                name: "TurmaMateriaProfessorEscola");

            migrationBuilder.DropTable(
                name: "VotoVideo");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "MovieList");

            migrationBuilder.DropTable(
                name: "Conteudo");

            migrationBuilder.DropTable(
                name: "NotaAlunoMateriaProfessor");

            migrationBuilder.DropTable(
                name: "Questionario");

            migrationBuilder.DropTable(
                name: "Resposta");

            migrationBuilder.DropTable(
                name: "Conta");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "Bimestre");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "AnoLetivo");

            migrationBuilder.DropTable(
                name: "AlunoEscola");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "ProfessorEscola");

            migrationBuilder.DropTable(
                name: "Pergunta");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Escola");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
