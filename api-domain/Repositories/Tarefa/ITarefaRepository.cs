using api_domain.Messaging.Tarefa;
using Microsoft.Identity.Client;

namespace api_domain.Repositories.Tarefa
{
    public interface ITarefaRepository
    {
        public List<Entidades.Tarefa> ObterTodasPorUsuario(Guid codigoUsuario);
        public void Inserir(Entidades.Tarefa tarefa);
        public List<Entidades.Tarefa> ObterPorRangeUsuario(Guid codigoUsuario, ObterTarefaPorRangeRequest obterTarefaPorRangeRequest);
        public void Atualizar(Entidades.Tarefa tarefa);
        public Entidades.Tarefa ObterPorCodigo(Guid codigoTarefa, Guid codigoUsuario);
        public List<Entidades.Tarefa> BuscarTarefasUltimaSemana(Guid codigoUsuario);
    }
}
