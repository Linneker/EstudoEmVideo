using acme.estudoemvideo.domain.DTO.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Seguranca
{
    public class AutorizacaoApiServices : ServiceBase<AutorizacaoApi>, IAutorizacaoApiServices
    {
        private readonly IAutorizacaoApiRepository _autorizacaoApiRepository;
        public AutorizacaoApiServices(IAutorizacaoApiRepository repositoryBase) : base(repositoryBase)
        {
            _autorizacaoApiRepository = repositoryBase;
        }

        public AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey)
        {
            return _autorizacaoApiRepository.GetAutorizacaoByAccessKey(acessesKey);
        }

        public Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey)
        {
            return _autorizacaoApiRepository.GetAutorizacaoByAccessKeyAsync(acessesKey);
        }
    }
}
