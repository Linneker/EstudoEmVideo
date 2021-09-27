using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.School.Util
{
    public class BoletimApplication : ApplicationBase<Boletim>, IBoletimApplication
    {
        private readonly IBoletimServices _boletimServices;

        public BoletimApplication(IBoletimServices boletimServices):base(boletimServices)
        {
            _boletimServices = boletimServices;
        }

        public List<Boletim> GetBoletinsByAlunoEscolaId(Guid alunoEscolaId)
        {
            return _boletimServices.GetBoletinsByAlunoEscolaId(alunoEscolaId);
        }

        public Task<List<Boletim>> GetBoletinsByAlunoEscolaIdAsync(Guid alunoEscolaId)
        {
            return _boletimServices.GetBoletinsByAlunoEscolaIdAsync(alunoEscolaId);
        }

        public List<Boletim> GetBoletinsByNotaAlunoMateriaProfessorId(Guid notaAlunoMateriaProfessorId)
        {
            return _boletimServices.GetBoletinsByNotaAlunoMateriaProfessorId(notaAlunoMateriaProfessorId);
        }

        public Task<List<Boletim>> GetBoletinsByNotaAlunoMateriaProfessorIdAsync(Guid notaAlunoMateriaProfessorId)
        {
            return _boletimServices.GetBoletinsByNotaAlunoMateriaProfessorIdAsync(notaAlunoMateriaProfessorId);
        }
    }
}
