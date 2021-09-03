using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Util
{
    public interface IParametroRepository : IRepositoryBase<Parametro>
    {

        List<Parametro> GetParametrosByNome(string nome);
        List<Parametro> GetParametrosByAtivo(bool ativo);
        Task<List<Parametro>> GetParametrosByNomeAsync(string nome);
        Task<List<Parametro>> GetParametrosByAtivoAsync(bool ativo);
    }
}
