using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class SerieViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Serie", TITULO_MODAL = "SÉRIE", URL_DOIS = "/Serie/GetDadosTable", ID_TABLE = "tabela_serie", CAMPOS_TABELA = "";

        public SerieViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            Turmas = new HashSet<TurmaViewModel>();
        }
        public string Nome { get; set; }


        public virtual ICollection<TurmaViewModel> Turmas { get; set; }
    }
}
