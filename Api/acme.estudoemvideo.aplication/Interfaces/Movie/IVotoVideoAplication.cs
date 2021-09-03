using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Movie
{
    public interface IVotoVideoAplication : IApplicationBase<VotoVideo>
    {
        List<VotoVideo> GetVotoVideoByLikeRelevancia(Guid idVideo, long likeRelevancia);
        List<VotoVideo> GetVotoVideoByObservacao(Guid idVideo, string observacao);

        Task<List<VotoVideo>> GetVotoVideoByLikeRelevanciaAsync(Guid idVideo, long likeRelevancia);
        Task<List<VotoVideo>> GetVotoVideoByObservacaoAsync(Guid idVideo, string observacao);

    }
}
