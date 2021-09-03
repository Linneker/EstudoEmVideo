using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel.Api.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.Map.Api
{
    public static class ConvertObjetoUsuario
    {
        public static Usuario UsuarioViewModelToUsuario(this UsuarioApiViewModel usuarioViewModel)
        {
            Usuario usuario = new Usuario();
            usuario.Cpf = usuarioViewModel.Cpf;
            usuario.DataDeNascimento = usuarioViewModel.DataDeNascimento;
            usuario.Email = usuarioViewModel.Email;
            usuario.Nome = usuarioViewModel.Nome;
            usuario.Telefone = usuarioViewModel.Telefone;
            return usuario;
        }
    }
}
