using acme.estudoemvideo.domain.DTO.Seguranca;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Seguranca
{
    public interface IAutorizacaoApiServices : IServicesBase<AutorizacaoApi>
    {
        AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey);
        Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey);
    }
}
