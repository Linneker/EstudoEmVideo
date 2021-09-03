using acme.estudoemvideo.util.ViewModel.Diary;
using acme.estudoemvideo.util.ViewModel.School.Notes;
using acme.estudoemvideo.util.ViewModel.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Matter
{
    public class MateriaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Materia", TITULO_MODAL = "MATERIA", URL_DOIS = "/Materia/GetDadosTable", ID_TABLE = "tabela_materia";
        private string[] CAMPOS_TABELA = new string[] {
        "{ data: 'nome' }", "{ data: 'dataCriacao' ", "{data: 'status',render: function (data, type) {if (data === 0) {return 'Ativo';}if (data === 1) {return 'Inativo';}}},"
        };
        public MateriaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, new List<string> {
            "{ data: 'nome' }", "{ data: 'dataCriacao'} ", "{data: 'status',render: function (data, type) {if (data === 0) {return 'Ativo';}if (data === 1) {return 'Inativo';}}}"
        })
        {
            ConteudosMaterias = new HashSet<ConteudoMateriaViewModel>();
            MateriasAgendas = new HashSet<MateriaAgendaViewModel>();
            FrequenciasAlunosMaterias = new HashSet<FrequenciaAlunoMateriaViewModel>();
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessorViewModel>();
            TurmaMateriaProfessorEscolas = new HashSet<TurmaProfessorEscolaViewModel>();
            TurmaMaterias = new HashSet<TurmaMateriaViewModel>();
            MateriasProfessores = new HashSet<MateriaProfessorEscolaViewModel>();

        }
        public string Nome { get; set; }

        public virtual ICollection<ConteudoMateriaViewModel> ConteudosMaterias { get; set; }
        public virtual ICollection<MateriaAgendaViewModel> MateriasAgendas { get; set; }
        public virtual ICollection<FrequenciaAlunoMateriaViewModel> FrequenciasAlunosMaterias { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessorViewModel> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaProfessorEscolaViewModel> TurmaMateriaProfessorEscolas { get; set; }
        public virtual ICollection<TurmaMateriaViewModel> TurmaMaterias { get; set; }
        public virtual ICollection<MateriaProfessorEscolaViewModel> MateriasProfessores { get; set; }

    }
}
