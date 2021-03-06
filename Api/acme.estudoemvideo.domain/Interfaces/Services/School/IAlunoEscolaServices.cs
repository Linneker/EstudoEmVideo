using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.School
{
    public interface IAlunoEscolaServices : IServicesBase<AlunoEscola>
    {
        List<AlunoEscola> GetAlunoEscolaByDataMatricula(DateTime dataMatricula);
        List<AlunoEscola> GetAlunoEscolaByMatricula(long matricula);

        Task<List<AlunoEscola>> GetAlunoEscolaByDataMatriculaAsync(DateTime dataMatricula);
        Task<List<AlunoEscola>> GetAlunoEscolaByMatriculaAsync(long matricula);

        List<AlunoEscola> GetAlunosEscolaByEscolaId(Guid escolaId);
        Task<List<AlunoEscola>> GetAlunosEscolaByEscolaIdAsync(Guid escolaId);

    }
}
