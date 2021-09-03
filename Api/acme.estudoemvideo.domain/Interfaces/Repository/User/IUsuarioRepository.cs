using acme.estudoemvideo.domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.User
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario GetUsuarioByCpf(string cpf);
        Usuario GetUsuarioByEmail(string email);
        List<Usuario> GetUsuarioByDataNascimento(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal);
        Task<List<Usuario>> GetUsuarioByDataNascimentoAsync(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal);
        Usuario GetUsuarioByTelefone(string telefone);
        List<Usuario> GetUsuarioByPermissao(string nomePermissao);
        Task<List<Usuario>> GetUsuarioByPermissaoAsync(string nomePermissao);
    }
}
