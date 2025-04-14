using api_domain.Entidades;
using api_domain.Repositories.TagTarefa;
using api_domain.Repositories.Tarefa;

namespace api_domain.Services.TagTarefas
{
    public class TagTarefasService(ITagTarefaRepository tagTarefasRepository, ITarefaRepository tarefaRepository) : ITagTarefasService
    {
        private readonly ITagTarefaRepository _tagTarefasRepository = tagTarefasRepository;
        private readonly ITarefaRepository _tarefaRepository = tarefaRepository;

        public void Deletar(TagTarefa tagTarefa)
        {
            _tagTarefasRepository.Deletar(tagTarefa);
        }

        public void Inserir(TagTarefa tagTarefa)
        {
            _tagTarefasRepository.Inserir(tagTarefa);
        }

        public List<TagTarefa> ObterTodasPorTarefa(Guid codigoTarefa, Guid codigoUsuario)
        {
            var _ = _tarefaRepository.ObterPorCodigo(codigoTarefa, codigoUsuario)
                ?? throw new Exception("Tarefa não encontrada.");

            return _tagTarefasRepository.ObterTodasPorTarefa(codigoTarefa);
        }
    }
}
