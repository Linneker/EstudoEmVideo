using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace acme.estudoemvideo.util.ViewModel.Seguranca
{
    public class SigningConfigurationsViewModel
    {
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentials { get; }

        public SigningConfigurationsViewModel()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
