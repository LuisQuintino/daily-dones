using api_domain.Entidades.Enumeradores;

namespace api_domain.Messaging.Tarefa
{
    public class InserirTarefaRequest
    {
        public Guid CodigoUsuario { get; set; }
        public string Descricao { get; set; }
        public SituacaoTarefa Situacao { get; set; }
    }
}
