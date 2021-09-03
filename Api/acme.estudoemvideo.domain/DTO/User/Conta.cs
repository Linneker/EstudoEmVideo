using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.User
{
    public class Conta : AbstractEntity
    {

        public Conta()
        {
            PermissoesContas = new HashSet<PermissaoConta>();
        }

        public Conta(string senha, string login)
        {
            _senha = SHA512(SHA384(SHA256(senha)));
            Login = login;
        }

        private string _senha;
        public bool? AlterarSenha { get; set; }
        public bool? ContaAtiva { get; set; }
        public bool Logado { get; set; }
        public string Senha
        {
            get => _senha;
            set
            {
                _senha =(SHA512(SHA384(SHA256(value))));
            }
        }
        public string Login { get; set; }
        public bool TermoDeAceite { get; set; }

        public Guid UsuarioId { get; set; }
               
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<PermissaoConta> PermissoesContas { get; set; }

       

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

        public override bool IsValid()
        {
            var validacoes = this.GetNotifications();
            this.AddNotifications(validacoes);
            return !(this.HasNotifications);
        }
    }
}
