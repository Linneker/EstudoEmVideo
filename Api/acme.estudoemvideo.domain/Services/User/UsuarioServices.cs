using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.User
{
    public class UsuarioServices : ServiceBase<Usuario>, IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository):base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario GetUsuarioByCpf(string cpf)
        {
            return _usuarioRepository.GetUsuarioByCpf(cpf);
        }
        public Task<List<Usuario>> GetUsuarioByDataNascimentoAsync(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            return _usuarioRepository.GetUsuarioByDataNascimentoAsync(dataNascimentoInicial, dataNascimentoFinal);
        }

        public List<Usuario> GetUsuarioByDataNascimento(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            return _usuarioRepository.GetUsuarioByDataNascimento(dataNascimentoInicial, dataNascimentoFinal);
        }

        public Usuario GetUsuarioByEmail(string email)
        {
            return _usuarioRepository.GetUsuarioByEmail(email);
        }

        public Usuario GetUsuarioByTelefone(string telefone)
        {
            return _usuarioRepository.GetUsuarioByTelefone(telefone);
        }

        public List<Usuario> GetUsuarioByPermissao(string nomePermissao)
        {
            return _usuarioRepository.GetUsuarioByPermissao(nomePermissao);
        }

        public Task<List<Usuario>> GetUsuarioByPermissaoAsync(string nomePermissao)
        {
            return _usuarioRepository.GetUsuarioByPermissaoAsync(nomePermissao);
        }
    }
}
