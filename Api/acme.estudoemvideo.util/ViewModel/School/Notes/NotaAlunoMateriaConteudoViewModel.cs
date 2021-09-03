using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Notes
{
    public class NotaAlunoMateriaConteudoViewModel : AbstractEntityViewModel
    {
        private const string URL = "/NotaAlunoMateriaConteudo", TITULO_MODAL = "NOTA ALUNO MATERIA", URL_DOIS = "/NotaAlunoMateriaConteudo/GetDadosTable", ID_TABLE = "tabela_nota_aluno_materia", CAMPOS_TABELA = "";

        public NotaAlunoMateriaConteudoViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        { }

        public Guid NotaAlunoMateriaId { get; set; }
        public Guid ConteudoId { get; set; }

        public NotaAlunoMateriaProfessorViewModel NotaAlunoMateria { get; set; }
        public Conteudo Conteudo { get; set; }
    }
}
