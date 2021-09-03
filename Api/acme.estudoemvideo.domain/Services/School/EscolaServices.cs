using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.School
{
    public class EscolaServices : ServiceBase<Escola>, IEscolaServices
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaServices(IEscolaRepository escolaRepository) : base(escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }
        public Escola GetEscolaByCnpj(string cnpj)
        {
            return _escolaRepository.GetEscolaByCnpj(cnpj);
        }

        public List<Escola> GetEscolasByNome(string nome)
        {
            return _escolaRepository.GetEscolasByNome(nome);
        }

        public Task<List<Escola>> GetEscolasByNomeAsync(string nome)
        {
            return _escolaRepository.GetEscolasByNomeAsync(nome);
        }

        public List<Escola> GetEscolasByRazaoSocial(string razaoSocial)
        {
            return _escolaRepository.GetEscolasByNome(razaoSocial);
        }

        public Task<List<Escola>> GetEscolasByRazaoSocialAsync(string razaoSocial)
        {
            return _escolaRepository.GetEscolasByRazaoSocialAsync(razaoSocial);
        }
    }
}
