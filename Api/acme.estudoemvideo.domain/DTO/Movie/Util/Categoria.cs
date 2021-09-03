using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Movie.Util
{
    public class Categoria : AbstractEntity
    {
        public Categoria()
        {
            CategoriasVideos = new HashSet<CategoriaVideo>();
        }
        public string Nome { get; set; }
        public EnumTipoCategoria Tipo { get; set; }
        
        public virtual ICollection<CategoriaVideo> CategoriasVideos { get; set; }
    }
}
