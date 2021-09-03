using acme.estudoemvideo.domain.DTO.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.School
{
    public interface IEscolaApplication : IApplicationBase<Escola>
    {
        Escola GetEscolaByCnpj(string cnpj);
        List<Escola> GetEscolasByNome(string nome);
        List<Escola> GetEscolasByRazaoSocial(string razaoSocial);
        Task<List<Escola>> GetEscolasByNomeAsync(string nome);
        Task<List<Escola>> GetEscolasByRazaoSocialAsync(string razaoSocial);
    }
}
