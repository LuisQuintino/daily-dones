using api_domain.Entidades;
using api_domain.Repositories.TagTarefa;

namespace api_domain.Services.TagTarefas
{
    public class TagTarefasService(ITagTarefaRepository tagTarefasRepository) : ITagTarefasService
    {
        private readonly ITagTarefaRepository _tagTarefasRepository = tagTarefasRepository;

        public void Deletar(TagTarefa tagTarefa)
        {
            _tagTarefasRepository.Deletar(tagTarefa);
        }

        public void Inserir(TagTarefa tagTarefa)
        {
            _tagTarefasRepository.Inserir(tagTarefa);
        }
    }
}
