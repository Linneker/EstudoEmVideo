using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School.Util
{
    public class BoletimServices : ServiceBase<Boletim>, IBoletimServices
    {
        private readonly IBoletimRepository _boletimRepository;

        public BoletimServices(IBoletimRepository boletimRepository):base(boletimRepository)
        {
            _boletimRepository = boletimRepository;
        }

        public List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId)
        {
            return _boletimRepository.GetBoletinsByAlunoEscolaId(alunoEscolaId);
        }

        public Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId)
        {
            return _boletimRepository.GetBoletinsByAlunoEscolaIdAsync(alunoEscolaId);
        }

        public List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid notaAlunoMateriaProfessorId)
        {
            return _boletimRepository.GetBoletinsByNotaAlunoMateriaProfessorId(notaAlunoMateriaProfessorId);
        }

        public Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid notaAlunoMateriaProfessorId)
        {
            return _boletimRepository.GetBoletinsByNotaAlunoMateriaProfessorIdAsync(notaAlunoMateriaProfessorId);
        }
    }
}
