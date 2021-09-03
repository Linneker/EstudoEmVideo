using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Notes;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Notes
{
    public class NotaAlunoMateriaConteudoRepository : RepositoryBase<NotaAlunoMateriaConteudo>, INotaAlunoMateriaConteudoRepository
    {
        public NotaAlunoMateriaConteudoRepository(Context db) : base(db)
        {
        }
    }
}
