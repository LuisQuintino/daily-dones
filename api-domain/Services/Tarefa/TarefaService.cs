using System.Net;
using api_domain.Messaging.Tarefa;
using api_domain.Repositories.Tag;
using api_domain.Repositories.TagTarefa;
using api_domain.Repositories.Tarefa;

namespace api_domain.Services.Tarefa
{
    public class TarefaService(ITarefaRepository tarefaRepository, ITagTarefaRepository tagTarefaRepository, ITagRepository tagRepository) : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository = tarefaRepository;
        private readonly ITagTarefaRepository _tagTarefaRepository = tagTarefaRepository;
        private readonly ITagRepository _tagRepository = tagRepository;

        public void Atualizar(AtualizarTarefaRequest atualizarTarefaRequest)
        {
            var tarefa =
                _tarefaRepository.ObterPorCodigo(atualizarTarefaRequest.CodigoTarefa, atualizarTarefaRequest.CodigoUsuario)
                ?? throw new Exception("Tarefa não encontrada");

            tarefa.Atualizar(atualizarTarefaRequest);
            _tarefaRepository.Atualizar(tarefa);
        }

        public List<UltimasTarefasResponse> BuscarTarefasUltimaSemana(Guid codigoUsuario)
        {
            var listaTarefas =
                _tarefaRepository.BuscarTarefasUltimaSemana(codigoUsuario);

            var listaTarefasTags = new List<UltimasTarefasResponse>();
            foreach (var tarefa in listaTarefas)
            {
                var listaTags = new List<Entidades.Tag>();
                _tagTarefaRepository.ObterTodasPorTarefa(tarefa.Codigo).ForEach(tagTarefa =>
                {
                    listaTags.Add(_tagRepository.ObterPorCodigo(tagTarefa.CodigoTag));
                });

                listaTarefasTags.Add(new UltimasTarefasResponse
                {
                    Tags = listaTags,
                    Tarefa = tarefa
                });
            }

            return listaTarefasTags;
        }

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
