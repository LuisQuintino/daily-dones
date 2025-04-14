using api_domain.Messaging.Tarefa;
using api_domain.Repositories.Tarefa;

namespace api_domain.Services.Tarefa
{
    public class TarefaService(ITarefaRepository tarefaRepository) : ITarefaService
    {
        public readonly ITarefaRepository _tarefaRepository = tarefaRepository;

        public void Inserir(InserirTarefaRequest inserirTarefaRequest)
        {
            var tarefa = new Entidades.Tarefa(inserirTarefaRequest);
            _tarefaRepository.Inserir(tarefa);
        }

        public List<Entidades.Tarefa> ObterPorRangeUsuario(Guid codigoUsuario, ObterTarefaPorRangeRequest obterTarefaPorRangeRequest)
        {
            var tarefasUsuario = 
                _tarefaRepository.ObterPorRangeUsuario(codigoUsuario, obterTarefaPorRangeRequest);

            return tarefasUsuario;
        }

        public List<Entidades.Tarefa> ObterTodasPorUsuario(Guid codigoUsuario)
        {
            return _tarefaRepository.ObterTodasPorUsuario(codigoUsuario);
        }
    }
}
