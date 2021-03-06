using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter.Book;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter.Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.Services.School.Matter.Book
{
    public class LivroServices : ServiceBase<Livro>, ILivroServices
    {
        private readonly ILivroRepository _livroRepository;

        public LivroServices(ILivroRepository livroRepository):base(livroRepository)
        {
            _livroRepository = livroRepository;
        }
    }
}
