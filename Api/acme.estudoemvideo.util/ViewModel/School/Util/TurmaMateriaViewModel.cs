using acme.estudoemvideo.util.ViewModel.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class TurmaMateriaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/TurmaMateria", TITULO_MODAL = "TURMA MATERIA", URL_DOIS = "/TurmaMateria/GetDadosTable", ID_TABLE = "tabela_turma_materia", CAMPOS_TABELA = "";

        public TurmaMateriaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }
        public Guid TurmaId { get; set; }
        public Guid MateriaId { get; set; }

        public TurmaViewModel Turma { get; set; }
        public MateriaViewModel Materia { get; set; }
    }
}
