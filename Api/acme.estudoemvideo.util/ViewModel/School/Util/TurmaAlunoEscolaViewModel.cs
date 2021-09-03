using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class TurmaAlunoEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/TurmaAlunoEscola", TITULO_MODAL = "TURMA ALUNO ESCOLA", URL_DOIS = "/TurmaAlunoEscola/GetDadosTable", ID_TABLE = "tabela_turma_aluno_escola", CAMPOS_TABELA = "";

        public TurmaAlunoEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public Guid TurmaId { get; set; }
        public Guid AlunoEscolaId { get; set; }

        public virtual TurmaViewModel Turma { get; set; }
        public virtual AlunoEscolaViewModel AlunoEscola { get; set; }
    }
}
