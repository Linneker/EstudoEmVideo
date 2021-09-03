using acme.estudoemvideo.domain.DTO.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Seguranca
{
    public class AutorizacaoApiRepository : RepositoryBase<AutorizacaoApi>, IAutorizacaoApiRepository
    {
        public AutorizacaoApiRepository(Context db) : base(db)
        {
        }

        public AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey)
        {
            AutorizacaoApi autorizacaoApi = _db.AutorizacoesApi.Where(t => t.AccessKey.Equals(acessesKey)).SingleOrDefault();
            return autorizacaoApi;
        }

        public Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey)
        {
            Task<AutorizacaoApi> autorizacaoApi = _db.AutorizacoesApi.Where(t => t.AccessKey.Equals(acessesKey)).SingleOrDefaultAsync();
            return autorizacaoApi;
        }
    }
}
