using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.aplication.Aplication.School.Notes
{
    public class NotaAlunoMateriaConteudoApplication : ApplicationBase<NotaAlunoMateriaConteudo>, INotaAlunoMateriaConteudoApplication
    {
        private readonly INotaAlunoMateriaConteudoServices _notaAlunoMateriaConteudoServices;

        public NotaAlunoMateriaConteudoApplication(INotaAlunoMateriaConteudoServices notaAlunoMateriaConteudoServices):base(notaAlunoMateriaConteudoServices)
        {
            _notaAlunoMateriaConteudoServices = notaAlunoMateriaConteudoServices;
        }
    }
}
