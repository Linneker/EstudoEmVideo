using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Notes
{
    public class NotaAlunoMateriaProfessorViewModel : AbstractEntityViewModel
    {
        private const string URL = "/NotaAlunoMateriaProfessor", TITULO_MODAL = "NOTA ALUNO MATERIA PROFESSOR", URL_DOIS = "/NotaAlunoMateriaProfessor/GetDadosTable", ID_TABLE = "tabela_nota_aluno_materia_professor", CAMPOS_TABELA = "";

        public NotaAlunoMateriaProfessorViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            NotaAlunoMateriaConteudos = new HashSet<NotaAlunoMateriaConteudoViewModel>();
        }

        public Guid NotaId { get; set; }
        public Guid AlunoEscolaId { get; set; }
        public Guid MateriaId { get; set; }
        public Guid ProfessorEscolaId { get; set; }
        
        public virtual NotaViewModel Nota { get; set; }
        public virtual AlunoEscolaViewModel AlunoEscola { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual ProfessorEscolaViewModel ProfessorEscola { get; set; }
        
        public virtual ICollection<NotaAlunoMateriaConteudoViewModel> NotaAlunoMateriaConteudos { get; set; }
    }
}
