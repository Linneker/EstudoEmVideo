using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
namespace acme.estudoemvideo.aplication.Aplication.Movie
{
    public class VotoVideoAplication : ApplicationBase<VotoVideo>, IVotoVideoAplication
    {
        private IVotoVideoServices _votoVideoRepository;
        public VotoVideoAplication(IVotoVideoServices votoVideoRepository) : base(votoVideoRepository)
        {
            _votoVideoRepository = votoVideoRepository;
        }
        public List<VotoVideo> GetVotoVideoByLikeRelevancia(Guid idVideo, long likeRelevancia)
        {
            return _votoVideoRepository.GetVotoVideoByLikeRelevancia(idVideo, likeRelevancia);
        }

        public List<VotoVideo> GetVotoVideoByObservacao(Guid idVideo, string observacao)
        {
            return _votoVideoRepository.GetVotoVideoByObservacao(idVideo, observacao);
        }
        public Task<List<VotoVideo>> GetVotoVideoByLikeRelevanciaAsync(Guid idVideo, long likeRelevancia)
        {
            return _votoVideoRepository.GetVotoVideoByLikeRelevanciaAsync(idVideo, likeRelevancia);
        }

        public Task<List<VotoVideo>> GetVotoVideoByObservacaoAsync(Guid idVideo, string observacao)
        {
            return _votoVideoRepository.GetVotoVideoByObservacaoAsync(idVideo, observacao);
        }
    }
}
