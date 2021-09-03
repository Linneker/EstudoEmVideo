using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.User
{
    public interface IContaAplication : IApplicationBase<Conta>
    {
        Conta Login(Conta conta);
        Conta GetContaByLogin(string login);
    }
}
