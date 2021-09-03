using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School
{
    public class AlunoEscolaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/AlunoEscola", TITULO_MODAL = "ALUNO ESCOLA", URL_DOIS = "/AlunoEscola/GetDadosTable", ID_TABLE = "tabela_aluno_escola", CAMPOS_TABELA = "";

        public AlunoEscolaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            FrequenciasAlunosMaterias = new HashSet<FrequenciaAlunoMateria>();
            NotasAlunosMateriasProfessores = new HashSet<NotaAlunoMateriaProfessor>();
            TurmasAlunosEscolas = new HashSet<TurmaAlunoEscola>();

        }
        public DateTime DataAlunoEscola { get; set; }
        public DateTime DataMatriculaAlunoNaEscola { get; set; }
        public long Matricula { get; set; }
        
        public Guid UsuarioId { get; set; }
        public Guid EscolaId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Aluno { get; set; }
        [ForeignKey("EscolaId")]
        public virtual EscolaViewModel Escola { get; set; }

        public virtual ICollection<FrequenciaAlunoMateria> FrequenciasAlunosMaterias { get; set; }
        public virtual ICollection<NotaAlunoMateriaProfessor> NotasAlunosMateriasProfessores { get; set; }
        public virtual ICollection<TurmaAlunoEscola> TurmasAlunosEscolas { get; set; }

    }
}
