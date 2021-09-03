using acme.estudoemvideo.domain.DTO.School.Matter;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Notes
{
    public class NotaAlunoMateriaConteudo : AbstractEntity
    {
        public Guid NotaAlunoMateriaId { get; set; }
        public Guid ConteudoId { get; set; }

        public NotaAlunoMateriaProfessor NotaAlunoMateria { get; set; }
        public Conteudo Conteudo { get; set; }
    }
}
