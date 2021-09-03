using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class AutorizacaoApiAplication : ApplicationBase<AutorizacaoApi>, IAutorizacaoApiAplication
    {
        private readonly IAutorizacaoApiServices _autorizacaoApiRepository;
        public AutorizacaoApiAplication(IAutorizacaoApiServices repositoryBase) : base(repositoryBase)
        {
            _autorizacaoApiRepository = repositoryBase;
        }

        public AutorizacaoApi GetAutorizacaoByAccessKey(string acessesKey)
        {
            return _autorizacaoApiRepository.GetAutorizacaoByAccessKey(acessesKey);
        }

        public async Task<AutorizacaoApi> GetAutorizacaoByAccessKeyAsync(string acessesKey)
        {
            return await _autorizacaoApiRepository.GetAutorizacaoByAccessKeyAsync(acessesKey);
        }
    }
}
