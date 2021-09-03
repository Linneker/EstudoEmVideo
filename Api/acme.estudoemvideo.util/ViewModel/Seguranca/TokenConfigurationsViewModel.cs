using System.ComponentModel.DataAnnotations.Schema;

namespace acme.estudoemvideo.util.ViewModel.Seguranca
{
    [NotMapped]
    public class TokenConfigurationsViewModel
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
