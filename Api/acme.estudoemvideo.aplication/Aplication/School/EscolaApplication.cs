using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.School
{
    public class EscolaApplication : ApplicationBase<Escola>, IEscolaApplication
    {
        private readonly IEscolaServices _escolaServices;
        public EscolaApplication(IEscolaServices escolaRepository) : base(escolaRepository)
        {
            _escolaServices = escolaRepository;
        }
        public Escola GetEscolaByCnpj(string cnpj)
        {
            return _escolaServices.GetEscolaByCnpj(cnpj);
        }
        public List<Escola> GetEscolasByNome(string nome)
        {
            return _escolaServices.GetEscolasByNome(nome);
        }

        public Task<List<Escola>> GetEscolasByRazaoSocialAsync(string razaoSocial)
        {
            return _escolaServices.GetEscolasByRazaoSocialAsync(razaoSocial);
        }
        public Task<List<Escola>> GetEscolasByNomeAsync(string nome)
        {
            return _escolaServices.GetEscolasByNomeAsync(nome);
        }

        public List<Escola> GetEscolasByRazaoSocial(string razaoSocial)
        {
            return _escolaServices.GetEscolasByRazaoSocial(razaoSocial);
        }
    }
}
