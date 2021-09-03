using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Movie.Util
{
    public interface ICategoriaAplication : IApplicationBase<Categoria>
    {
        Categoria GetCategoriaByNome(string nome);
        Categoria GetCategoriaByTipo(EnumTipoCategoria tipoCategoria);
    }
}
