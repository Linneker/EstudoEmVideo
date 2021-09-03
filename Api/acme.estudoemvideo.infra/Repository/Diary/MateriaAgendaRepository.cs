using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.Diary
{
    public class MateriaAgendaRepository : RepositoryBase<MateriaAgenda>
    {
        public MateriaAgendaRepository(Context db) : base(db)
        {
        }
    }
}
