using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.User
{
    public interface IContaRepository : IRepositoryBase<Conta>
    {
        Conta Login(Conta conta);
       
    }
}
