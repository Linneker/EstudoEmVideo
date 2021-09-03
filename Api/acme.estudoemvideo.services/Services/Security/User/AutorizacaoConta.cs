using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace acme.estudoemvideo.services.Services.Security.User
{
    public class AutorizacaoConta : IAuthorizationRequirement
    {
        public AutorizacaoConta()
        { }
        public AutorizacaoConta(IContaAplication contaAplication, IPermissaoMenuApplication pmA, string login, string senha)
        {
            Permissoes = new List<Permissao>();
            Menus = new List<Menu>();
            var cnt = contaAplication.Login(new Conta(senha, login));
            foreach (var perCnt in cnt.PermissoesContas)
            {
                var listaPermissaoMenu = pmA.GetMenusByPermissaoId(perCnt.Permissao.Id);
                foreach (var mn in listaPermissaoMenu)
                {
                    Menus.Add(mn.Menu);
                }
                perCnt.Permissao.PermissoesContas = null;
                Permissoes.Add(perCnt.Permissao);
            }

        }

        public List<Permissao> Permissoes { get; private set; }
        public List<Menu> Menus { get; private set; }
    
        public string GeraKey(string cnpj)
        {
            return MD5(SHA512(SHA384(SHA256($"{cnpj}{Guid.NewGuid()}"))));
        }


        protected internal static string SHA512(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA512Managed SHhash = new SHA512Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string SHA256(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA256Managed SHhash = new SHA256Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string SHA384(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA384Managed SHhash = new SHA384Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string MD5(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            HMACMD5 SHhash = new HMACMD5();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
    }
}
