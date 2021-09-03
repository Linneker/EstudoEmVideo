using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter.Book;
using acme.estudoemvideo.infra.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Repository.School.Matter.Book
{
    public class ApostilaRepository : RepositoryBase<Apostila>, IApostilaRepository
    {
        public ApostilaRepository(Context db) : base(db)
        {
        }
    }
}
