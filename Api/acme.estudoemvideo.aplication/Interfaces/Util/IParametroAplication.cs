using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Util
{
    public interface IParametroAplication : IApplicationBase<Parametro>
    {
        Task<List<Parametro>> GetParametrosByNomeAsync(string nome);
        Task<List<Parametro>> GetParametrosByAtivoAsync(bool ativo);
        List<Parametro> GetParametrosByNome(string nome);
        List<Parametro> GetParametrosByAtivo(bool ativo);
    }
}
