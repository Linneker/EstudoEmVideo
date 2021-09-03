using acme.estudoemvideo.util.ViewModel.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Diary
{
    public class MateriaAgendaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/MateriaAgenda", TITULO_MODAL = "MATERIA AGENDA", URL_DOIS = "/MateriaAgenda/GetDadosTable", ID_TABLE = "tabela_materia_agenda", CAMPOS_TABELA = "";

        public MateriaAgendaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public DateTime DataCadastro { get; set; }
        public Guid MateriaId { get; set; }
        public Guid AgendaId { get; set; }

        public virtual MateriaViewModel Materia { get; set; }
        public virtual AgendaViewModel Agenda { get; set; }
    }
}
