using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.School
{
    public interface IEscolaServices : IServicesBase<Escola>
    {
        Escola GetEscolaByCnpj(string cnpj);
        List<Escola> GetEscolasByNome(string nome);
        List<Escola> GetEscolasByRazaoSocial(string razaoSocial);
        Task<List<Escola>> GetEscolasByNomeAsync(string nome);
        Task<List<Escola>> GetEscolasByRazaoSocialAsync(string razaoSocial);
    }
}
