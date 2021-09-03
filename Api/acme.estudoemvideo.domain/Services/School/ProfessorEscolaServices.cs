using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School
{
    public class ProfessorEscolaServices: ServiceBase<ProfessorEscola>, IProfessorEscolaServices
    {
        private readonly IProfessorEscolaRepository _professorEscolaRepository;

        public ProfessorEscolaServices(IProfessorEscolaRepository professorEscolaRepository):base(professorEscolaRepository)
        {
            _professorEscolaRepository = professorEscolaRepository;
        }

        public List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId)
        {
            return _professorEscolaRepository.GetProfessorEscolaByEscolaId(escolaId);
        }

        public Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId)
        {
            return _professorEscolaRepository.GetProfessorEscolaByEscolaIdAsync(escolaId);
        }
    }
}
