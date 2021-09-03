using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Util
{
    public class ParametroServices : ServiceBase<Parametro>, IParametroServices
    {
        private readonly IParametroRepository _parametroRepository;
        public ParametroServices(IParametroRepository parametroRepository):base(parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }

        public Task<List<Parametro>> GetParametrosByAtivoAsync(bool ativo)
        {
            return _parametroRepository.GetParametrosByAtivoAsync(ativo);
        }

        public Task<List<Parametro>> GetParametrosByNomeAsync(string nome)
        {
            return _parametroRepository.GetParametrosByNomeAsync(nome);
        }
        public List<Parametro> GetParametrosByAtivo(bool ativo)
        {
            return _parametroRepository.GetParametrosByAtivo(ativo);
        }

        public List<Parametro> GetParametrosByNome(string nome)
        {
            return _parametroRepository.GetParametrosByNome(nome);
        }
    }
}
