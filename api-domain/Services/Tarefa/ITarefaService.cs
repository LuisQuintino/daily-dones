using api_domain.Messaging.Tarefa;

namespace api_domain.Services.Tarefa
{
    public interface ITarefaService
    {
        public List<Entidades.Tarefa> ObterTodasPorUsuario(Guid codigoUsuario);
        public void Inserir(InserirTarefaRequest inserirTarefaRequest);
        public List<Entidades.Tarefa> ObterPorRangeUsuario(Guid codigoUsuario, ObterTarefaPorRangeRequest obterTarefaPorRangeRequest);
    }
}
