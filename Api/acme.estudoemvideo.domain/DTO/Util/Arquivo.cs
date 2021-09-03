using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Util
{
    public class Arquivo : AbstractEntity
    {
        public Arquivo()
        {
            Apostilas = new HashSet<Apostila>();
            Livros = new HashSet<Livro>();
        }

        public string NomeArquivoSalvo { get; set; }
        public string NomeArquivo { get; set; }
        public string Url { get; set; }
        public string HashArquivo { get; set; }

        public virtual ICollection<Apostila> Apostilas { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }

    }
}
