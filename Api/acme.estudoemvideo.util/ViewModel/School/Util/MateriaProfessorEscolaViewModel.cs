using acme.estudoemvideo.util.ViewModel.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class MateriaProfessorEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/MateriaProfessorEscola", TITULO_MODAL = "Materia Professor Escola", URL_DOIS = "/MateriaProfessorEscola/GetDadosTable", ID_TABLE = "tabela_materia_professor_escola", CAMPOS_TABELA = "";

        public MateriaProfessorEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }
        public Guid MateriaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }

        public MateriaViewModel Materia { get; set; }
        public ProfessorEscolaViewModel ProfessorEscola { get; set; }

    }
}
