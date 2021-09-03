using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class FrequenciaAlunoMateriaServices: ServiceBase<FrequenciaAlunoMateria>, IFrequenciaAlunoMateriaServices
    {
        private readonly IFrequenciaAlunoMateriaRepository _frequenciaAlunoMateriaRepository;

        public FrequenciaAlunoMateriaServices(IFrequenciaAlunoMateriaRepository frequenciaAlunoMateriaRepository):base(frequenciaAlunoMateriaRepository)
        {
            _frequenciaAlunoMateriaRepository = frequenciaAlunoMateriaRepository;
        }
    }
}
