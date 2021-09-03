using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class TurmaBimestreViewModel : AbstractEntityViewModel
    {
        private const string URL = "/TurmaBimestreEscola", TITULO_MODAL = "TURMA BIMESTRE ESCOLA", URL_DOIS = "/TurmaBimestreEscola/GetDadosTable", ID_TABLE = "tabela_turma_bimestre_escola", CAMPOS_TABELA = "";

        public TurmaBimestreViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public Guid BimestreId { get; set; }
        public Guid TurmaId { get; set; }

        public virtual TurmaViewModel Turma { get; set; }
        public virtual BimestreViewModel Bimestre { get; set; }
    }
}
