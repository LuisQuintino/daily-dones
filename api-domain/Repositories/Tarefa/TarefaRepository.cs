using api_domain.Config;
using api_domain.Entidades;
using api_domain.Messaging.Tarefa;

namespace api_domain.Repositories.Tarefa
{
    public class TarefaRepository(BdContext bdContext) : ITarefaRepository
    {
        public BdContext Context { get; set; } = bdContext;

        public void Atualizar(Entidades.Tarefa tarefa)
        {
            this.Context.Tarefas.Update(tarefa);
            this.Context.SaveChanges();
        }

        public void Inserir(Entidades.Tarefa tarefa)
        {
            this.Context.Tarefas.Add(tarefa);
            this.Context.SaveChanges();
        }

        public Entidades.Tarefa ObterPorCodigo(Guid codigoTarefa, Guid codigoUsuario)
        {
            return this.Context.Tarefas.Where(x => x.Codigo == codigoTarefa && x.CodigoUsuario == codigoUsuario)?.SingleOrDefault();
        }

        public List<Entidades.Tarefa> ObterPorRangeUsuario(Guid codigoUsuario, ObterTarefaPorRangeRequest obterTarefaPorRangeRequest)
        {
            var tarefas = Context.Tarefas
                .Where
                (t => t.CodigoUsuario == codigoUsuario
                 && t.DtInclusao <= obterTarefaPorRangeRequest.DtInicio
                 && t.DtInclusao >= obterTarefaPorRangeRequest.DtFim)
                .ToList();

            return tarefas;
        }

        public List<Entidades.Tarefa> ObterTodasPorUsuario(Guid codigoUsuario)
        {
            var tarefas = Context.Tarefas
                .Where(t => t.CodigoUsuario == codigoUsuario)
                .ToList();

            return tarefas;
        }
    }
}
