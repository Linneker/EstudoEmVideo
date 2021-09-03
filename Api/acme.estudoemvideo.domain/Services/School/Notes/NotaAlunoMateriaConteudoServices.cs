using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Notes
{
    public class NotaAlunoMateriaConteudoServices : ServiceBase<NotaAlunoMateriaConteudo>, INotaAlunoMateriaConteudoServices
    {
        private readonly INotaAlunoMateriaConteudoRepository _notaAlunoMateriaConteudoRepository;

        public NotaAlunoMateriaConteudoServices(INotaAlunoMateriaConteudoRepository repositoryBase) : base(repositoryBase)
        {
            _notaAlunoMateriaConteudoRepository = repositoryBase;
        }
    }
}
