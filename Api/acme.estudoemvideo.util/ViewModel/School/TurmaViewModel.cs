using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.util.ViewModel.School.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School
{
    public class TurmaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Turma", TITULO_MODAL = "TURMA", URL_DOIS = "/Turma/GetDadosTable", ID_TABLE = "tabela_turma", CAMPOS_TABELA = "";

        public TurmaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            TurmasAlunosEscolas = new HashSet<TurmaAlunoEscolaViewModel>();
            TurmaProfessorEscolas = new HashSet<TurmaProfessorEscolaViewModel>();
            TurmaBimestres = new HashSet<TurmaBimestreViewModel>();
            TurmaMaterias = new HashSet<TurmaMateriaViewModel>();
        }

        public string Nome { get; set; }
        
        [Display(Name = "Período")]
        public EnumPeriodo Periodo { get; set; }
        
        [Display(Name = "Série")]
        public Guid SerieId { get; set; }
        [Display(Name = "Escola")]
        public Guid EscolaId { get; set; }

        public virtual EscolaViewModel Escola { get; set; }

        public virtual SerieViewModel Serie { get; set; }
        [Display(Name = "Aluno(s)")]
        public virtual ICollection<TurmaAlunoEscolaViewModel> TurmasAlunosEscolas { get; set; }
        [Display(Name = "Professore(s)")]
        public virtual ICollection<TurmaProfessorEscolaViewModel> TurmaProfessorEscolas { get; set; }
        [Display(Name = "Bimestre(s)")]
        public virtual ICollection<TurmaBimestreViewModel> TurmaBimestres { get; set; }
        [Display(Name = "Materia(s)")]
        public virtual ICollection<TurmaMateriaViewModel> TurmaMaterias { get; set; }

        
    }
}
