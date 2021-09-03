using acme.estudoemvideo.domain.DTO.Seguranca.Site;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site
{
    public interface IPermissaoRepository : IRepositoryBase<Permissao>
    {
        Permissao GetPermissaoByNome(string nome);
    }
}
