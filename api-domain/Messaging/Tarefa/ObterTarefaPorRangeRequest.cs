using System.Text.Json.Serialization;

namespace api_domain.Messaging.Tarefa
{
    public class ObterTarefaPorRangeRequest
    {
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}
