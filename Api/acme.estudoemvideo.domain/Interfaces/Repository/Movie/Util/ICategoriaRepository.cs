using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Movie.Util
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        Categoria GetCategoriaByNome(string nome);
        Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria);
    }
}
