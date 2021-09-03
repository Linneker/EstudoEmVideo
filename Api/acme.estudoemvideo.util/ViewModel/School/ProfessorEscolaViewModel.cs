using acme.estudoemvideo.util.ViewModel.School.Notes;
using acme.estudoemvideo.util.ViewModel.School.Util;
using acme.estudoemvideo.util.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School
{
    public class ProfessorEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/ProfessorEscola", TITULO_MODAL = "PROFESSOR ESCOLA", URL_DOIS = "/ProfessorEscola/GetDadosTable", ID_TABLE = "tabela_professor_escola", CAMPOS_TABELA = "";

        public ProfessorEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessorViewModel>();
            TurmaMateriaProfessorEscolas = new HashSet<TurmaProfessorEscolaViewModel>();
            MateriasProfessores = new HashSet<MateriaProfessorEscolaViewModel>();
        }

        public int PopularidadeProfessor { get; set; }
        
        public Guid UsuarioId { get; set; }
        public Guid EscolaId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual UsuarioViewModel Usuario { get; set; }
        [ForeignKey("EscolaId")]
        public virtual EscolaViewModel Escola { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessorViewModel> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaProfessorEscolaViewModel> TurmaMateriaProfessorEscolas { get; set; }
        public virtual ICollection<MateriaProfessorEscolaViewModel> MateriasProfessores { get; set; }
    }
}
