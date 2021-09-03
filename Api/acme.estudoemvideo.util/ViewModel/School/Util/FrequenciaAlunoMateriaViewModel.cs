using acme.estudoemvideo.util.ViewModel.Diary;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.School.Util
{
    public class FrequenciaAlunoMateriaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/FrequenciaAlunoMateria", TITULO_MODAL = "FREQUENCIA ALUNO MATERIA", URL_DOIS = "/FrequenciaAlunoMateria/GetDadosTable", ID_TABLE = "tabela_frequencia_aluno_materia", CAMPOS_TABELA = "";

        public FrequenciaAlunoMateriaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {

        }
        public Guid AlunoEscolaId { get; set; }
        public Guid MateriaId { get; set; }
        public Guid AgendaId { get; set; }

        public int QuantidadeFalta{ get; set; }
        public int QuantidadePresenca { get; set; }
        public int QuantidadeFaltaJustificada { get; set; }
        public string JustificativaFalta { get; set; }

        public AlunoEscolaViewModel AlunoEscola { get; set; }
        public MateriaViewModel Materia { get; set; }
        public AgendaViewModel Agenda { get; set; }
    }
}
