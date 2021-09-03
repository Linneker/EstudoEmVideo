using acme.estudoemvideo.util.ViewModel.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class TurmaProfessorEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/TurmaMateriaProfessorEscola", TITULO_MODAL = "TURMA MATERIA PROFESSOR ESCOLA", URL_DOIS = "/TurmaMateriaProfessorEscola/GetDadosTable", ID_TABLE = "tabela_turma_materia_professor_escola", CAMPOS_TABELA = "";

        public TurmaProfessorEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public Guid TurmaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }


        public TurmaViewModel Turma { get; set; }
        public ProfessorEscolaViewModel ProfessorEscola { get; set; }
    }
}
