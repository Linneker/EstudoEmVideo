using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School
{
    public class AlunoEscolaServices : ServiceBase<AlunoEscola>, IAlunoEscolaServices
    {
        private readonly IAlunoEscolaRepository _alunoEscolaRepository;
        public AlunoEscolaServices(IAlunoEscolaRepository alunoEscolaRepository):base(alunoEscolaRepository)
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
            return _alunoEscolaRepository.GetAlunoEscolaByEscolaId(escolaId);
        }

        public Task<List<AlunoEscola>> GetAlunosEscolaByEscolaIdAsync(Guid escolaId)
        {
            return _alunoEscolaRepository.GetAlunoEscolaByEscolaIdAsync(escolaId);
        }
    }
}
