using acme.estudoemvideo.domain.DTO.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Seguranca
{
    public interface IAutorizacaoApiRepository : IRepositoryBase<AutorizacaoApi>
    {

        AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey);
        Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey);

    }
}
