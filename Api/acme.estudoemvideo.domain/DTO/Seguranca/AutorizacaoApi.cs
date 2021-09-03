namespace acme.estudoemvideo.domain.DTO.Seguranca
{
    public class AutorizacaoApi : AbstractEntity
    {
        public string AccessKey { get; set; }
        public string CnpjEmpresa { get; set; }
    }
}
