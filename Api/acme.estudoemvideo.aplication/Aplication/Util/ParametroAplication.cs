using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Util
{
    public class ParametroAplication : ApplicationBase<Parametro>, IParametroAplication
    {
        private readonly IParametroServices _parametroRepository;
        public ParametroAplication(IParametroServices parametroRepository):base(parametroRepository)
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
