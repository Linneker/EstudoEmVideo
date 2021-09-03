using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.School
{
    public class AlunoEscolaApplication : ApplicationBase<AlunoEscola>, IAlunoEscolaApplication
    {
        private readonly IAlunoEscolaServices _alunoEscolaRepository;
        public AlunoEscolaApplication(IAlunoEscolaServices alunoEscolaRepository):base(alunoEscolaRepository)
        {
            _alunoEscolaRepository = alunoEscolaRepository;
        }
        public List<AlunoEscola> GetAlunoEscolaByDataMatricula(DateTime dataMatricula)
        {
            return _alunoEscolaRepository.GetAlunoEscolaByDataMatricula(dataMatricula);
        }

        public List<AlunoEscola> GetAlunoEscolaByMatricula(long matricula)
        {
            return _alunoEscolaRepository.GetAlunoEscolaByMatricula(matricula);
        }
        public Task<List<AlunoEscola>> GetAlunoEscolaByDataMatriculaAsync(DateTime dataMatricula)
        {
            return _alunoEscolaRepository.GetAlunoEscolaByDataMatriculaAsync(dataMatricula);
        }

        public Task<List<AlunoEscola>> GetAlunoEscolaByMatriculaAsync(long matricula)
        {
            return _alunoEscolaRepository.GetAlunoEscolaByMatriculaAsync(matricula);
        }

        public List<AlunoEscola> GetAlunosEscolaByEscolaId(Guid escolaId)
        {
            return _alunoEscolaRepository.GetAlunosEscolaByEscolaId(escolaId);
        }

        public Task<List<AlunoEscola>> GetAlunosEscolaByEscolaIdAsync(Guid escolaId)
        {
            return _alunoEscolaRepository.GetAlunosEscolaByEscolaIdAsync(escolaId);
        }
    }
}
