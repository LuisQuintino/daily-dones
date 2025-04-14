namespace api_domain.Messaging.Tag
{
    public class VincularTagTarefaRequest
    {
        public Guid CodigoUsuario { get; set; }
        public Guid CodigoTarefa { get; set; }
        public Guid CodigoTag { get; set; }
    }
}
