using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Movie
{
    public class VotoVideoServices : ServiceBase<VotoVideo>, IVotoVideoServices
    {
        private IVotoVideoRepository _votoVideoRepository;
        public VotoVideoServices(IVotoVideoRepository votoVideoRepository) : base(votoVideoRepository)
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
