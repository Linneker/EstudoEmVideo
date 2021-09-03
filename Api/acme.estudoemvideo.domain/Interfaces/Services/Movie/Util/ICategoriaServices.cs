using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services.Movie.Util
{
    public interface ICategoriaServices : IServicesBase<Categoria>
    {
        Categoria GetCategoriaByNome(string nome);
        Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria);
    }
}
