using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using acme.estudoemvideo.domain.DTO.School.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.School.Matter
{
    public class Conteudo : AbstractEntity
    {
        public Conteudo()
        {
            ConteudosMaterias = new HashSet<ConteudoMateria>();
            Apostilas = new HashSet<Apostila>();
            Livros = new HashSet<Livro>();
            NotaAlunoMateriaConteudos = new HashSet<NotaAlunoMateriaConteudo>();
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ConteudoMateria> ConteudosMaterias { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
        public virtual ICollection<Apostila> Apostilas { get; set; }
        public virtual ICollection<NotaAlunoMateriaConteudo> NotaAlunoMateriaConteudos { get; set; }

    }
}
