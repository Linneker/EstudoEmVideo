using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Movie
{
    public interface IVideoServices : IServicesBase<Video>
    {
        List<Video> GetVideoByName(string name);
        List<Video> GetVideoByPopularidade(EnumPopularidade enumPopularidade);
        List<Video> GetVideoByVizualizacao(long vizualizacao);
        List<Video> GetVideoByVizualizacaoEmNumero(long numeroVizualizador);
        List<Video> GetVideosByCategoriaId(Guid categoriaId);

        Task<List<Video>> GetVideoByNameAsync(string name);
        Task<List<Video>> GetVideoByPopularidadeAsync(EnumPopularidade enumPopularidade);
        Task<List<Video>> GetVideoByVizualizacaoAsync(long vizualizacao);
        Task<List<Video>> GetVideoByVizualizacaoEmNumeroAsync(long numeroVizualizador);
    }
}
