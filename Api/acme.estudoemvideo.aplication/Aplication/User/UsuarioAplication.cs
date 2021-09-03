using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.User
{
    public class UsuarioAplication : ApplicationBase<Usuario>, IUsuarioAplication
    {
        private readonly IUsuarioServices _usuarioRepository;
        private readonly IContaServices _contaServices;
        public UsuarioAplication(IUsuarioServices usuarioRepository, IContaServices contaServices) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _contaServices = contaServices;
        }
        public ResponseApi CadastroUsuario(Usuario usuario, Conta conta)
        {
            ResponseApi responseApi = this.Add(usuario,"USUARIO");
            if (!(responseApi.HasNotifications))
            {
                Conta contaCadastrada = _contaServices.Add(conta);
                if (contaCadastrada.HasNotifications)
                {
                    responseApi = new ResponseApi(EnumHttp.BAD_REQUEST, "Conta Não Cadastrado", "Por favor verifique as informações fornecidas", EnumLog.WARNING.ToString(), contaCadastrada.Notifications.ToList());
                }
                else
                {
                    Notification cadastrado = this.Commit();
                    if (cadastrado.Key == "200")
                    {
                        responseApi = new ResponseApi(EnumHttp.SUCESSO, "Usuario Cadastrado!", "Maravilha, o usuário foi cadastrado com sucesso!", EnumLog.SUCESS.ToString());
                    }
                    else
                    {
                        responseApi = new ResponseApi(EnumHttp.BAD_REQUEST, "Usuario Não Cadastrado", "Por favor verifique as informações fornecidas", EnumLog.WARNING.ToString());
                    }
                }

            }
            return responseApi;
        }
        public Usuario GetUsuarioByCpf(string cpf)
        {
            return _usuarioRepository.GetUsuarioByCpf(cpf);
        }

        public List<Usuario> GetUsuarioByDataNascimento(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            return _usuarioRepository.GetUsuarioByDataNascimento(dataNascimentoInicial, dataNascimentoFinal);
        }

        public Task<List<Usuario>> GetUsuarioByDataNascimentoAsync(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            return _usuarioRepository.GetUsuarioByDataNascimentoAsync(dataNascimentoInicial, dataNascimentoFinal);
        }

        public Usuario GetUsuarioByEmail(string email)
        {
            return _usuarioRepository.GetUsuarioByEmail(email);
        }

        public List<Usuario> GetUsuarioByPermissao(string nomePermissao)
        {
            return _usuarioRepository.GetUsuarioByPermissao(nomePermissao);
        }

        public Task<List<Usuario>> GetUsuarioByPermissaoAsync(string nomePermissao)
        {
            return _usuarioRepository.GetUsuarioByPermissaoAsync(nomePermissao);
        }

        public Usuario GetUsuarioByTelefone(string telefone)
        {
            return _usuarioRepository.GetUsuarioByTelefone(telefone);
        }
    }
}
