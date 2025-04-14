using System.Text.Json.Serialization;
using api_domain.Entidades.Enumeradores;

namespace api_domain.Messaging.Tarefa
{
    public class AtualizarTarefaRequest
    {
        public Guid CodigoTarefa { get; set; }
        public string Descricao { get; set; }
        public SituacaoTarefa Situacao { get; set; }
        [JsonIgnore]
        public Guid CodigoUsuario { get; set; }
    }
}
