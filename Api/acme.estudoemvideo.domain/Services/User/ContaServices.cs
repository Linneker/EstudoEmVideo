using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.User
{
    public class ContaServices : ServiceBase<Conta>, IContaServices
    {
        private IContaRepository _contaRepository;
        public ContaServices(IContaRepository contaRepository) : base(contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public Conta Login(Conta conta)
        {
            return _contaRepository.Login(conta);
        }
    }
}
