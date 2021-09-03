using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Matter
{
    public class ConteudoMateriaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/ConteudoMateria", TITULO_MODAL = "CONTEUDO MATERIA", URL_DOIS = "/ConteudoMateria/GetDadosTable", ID_TABLE = "tabela_conteudo_materia", CAMPOS_TABELA = "";

        public ConteudoMateriaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            Materia = new MateriaViewModel();
            Conteudo = new ConteudoViewModel();
        }
        public DateTime DataAtribuicao { get; set; }

        public Guid ConteudoId { get; set; }
        public Guid MateriaId { get; set; }

        public virtual MateriaViewModel Materia { get; set; }
        public virtual ConteudoViewModel Conteudo { get; set; }
    }
}
