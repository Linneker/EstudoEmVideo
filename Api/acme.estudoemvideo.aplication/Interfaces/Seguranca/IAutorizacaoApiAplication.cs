using acme.estudoemvideo.domain.DTO.Seguranca;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Movie
{
    public interface IAutorizacaoApiAplication : IApplicationBase<AutorizacaoApi>
    {
        AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey);
        Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey);

    }
}
