using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Diary
{
    public class AgendaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Agenda", TITULO_MODAL = "ARQUIVO", URL_DOIS = "/Agenda/GetDadosTable", ID_TABLE = "tabela_agenda", CAMPOS_TABELA = "";

        public AgendaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            MateriasAgendas = new HashSet<MateriaAgendaViewModel>();
        }

        public string Compromisso{ get; set; }


        public bool Prova { get; set; }
        
        public UsuarioViewModel Usuario { get; set; }
        public AnoLetivoViewModel AnoLetivo { get; set; }

        public virtual ICollection<MateriaAgendaViewModel> MateriasAgendas { get; set; }
    }
}
