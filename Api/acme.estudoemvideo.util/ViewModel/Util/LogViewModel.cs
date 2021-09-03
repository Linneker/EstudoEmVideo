using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class LogViewModel<TEntity> : AbstractEntityViewModel where TEntity : class
    {
        private const string URL = "/Log", TITULO_MODAL = "LOG", URL_DOIS = "/Log/GetDadosTable", ID_TABLE = "tabela_log", CAMPOS_TABELA = "";

        public LogViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
        }

        public string Nome { get; set; }
        public DateTime? DataLog { get; set; }

        public string Descricao { get; set; }


        public string ObjetoJson { get; set; }
        public string ModificaoObjeto { get; set; }

        [NotMapped]
        public TEntity Objeto { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
        
    }
}
