using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Notes
{
    public class NotaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Nota", TITULO_MODAL = "NOTA", URL_DOIS = "/Nota/GetDadosTable", ID_TABLE = "tabela_nota", CAMPOS_TABELA = "";

        public NotaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessorViewModel>();
        }
        public int Numero { get; set; }
        public bool IsAprovado { get; set; }
        public bool IsRecuperacao { get; set; }
        public bool IsReprovado { get; set; }

        public ICollection<NotaAlunoMateriaProfessorViewModel> NotasAlunosMateriasProfessores { get; set; }
    }
}
