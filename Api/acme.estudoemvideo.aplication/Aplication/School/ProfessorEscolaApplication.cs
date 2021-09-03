using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.School
{
    public class ProfessorEscolaApplication : ApplicationBase<ProfessorEscola>, IProfessorEscolaApplication
    {
        private readonly IProfessorEscolaServices _professorEscolaServices;

        public ProfessorEscolaApplication(IProfessorEscolaServices professorEscolaServices):base(professorEscolaServices)
        {
            _professorEscolaServices = professorEscolaServices;
        }

        public List<ProfessorEscola> GetProfessorEscolaByEscolaId(Guid escolaId)
        {
            return _professorEscolaServices.GetProfessorEscolaByEscolaId(escolaId);
        }

        public Task<List<ProfessorEscola>> GetProfessorEscolaByEscolaIdAsync(Guid escolaId)
        {
            return _professorEscolaServices.GetProfessorEscolaByEscolaIdAsync(escolaId);
        }
    }
}
