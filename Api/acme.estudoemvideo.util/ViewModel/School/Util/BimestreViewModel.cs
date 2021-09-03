using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class BimestreViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Bimestre", TITULO_MODAL = "BIMESTRE", URL_DOIS = "/Bimestre/GetDadosTable", ID_TABLE = "tabela_bimestre", CAMPOS_TABELA = "";

        public BimestreViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            TurmaBimestres = new HashSet<TurmaBimestreViewModel>();
        }

        public string Nome { get; set; }

        public virtual ICollection<TurmaBimestreViewModel> TurmaBimestres { get; set; }
    }
}
