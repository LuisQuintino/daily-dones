using api_domain.Repositories.Tag;

namespace api_domain.Services.Tag
{
    public class TagService(ITagRepository tagRepository) : ITagService
    {
        private readonly ITagRepository _tagRepository = tagRepository;

        public void Inserir(Entidades.Tag tag)
        {
            _tagRepository.Inserir(tag);
        }

        public List<Entidades.Tag> ObterTodasPorUsuario(Guid codigoUsuario)
        {
            return _tagRepository.ObterTodasPorUsuario(codigoUsuario);
        }
    }
}
