using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using System;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site
{
    public interface IPermissaoContaRepository : IRepositoryBase<PermissaoConta>
    {
        PermissaoConta GetPermissaoContaByData(DateTime dataCadastro);
    }
}
