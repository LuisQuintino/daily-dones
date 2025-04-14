
using api_domain.Config;

namespace api_domain.Repositories.Tag
{
    public class TagRepository(BdContext context) : ITagRepository
    {
        public BdContext Context { get; set; } = context;

        public void Inserir(Entidades.Tag tag)
        {
            Context.Tags.Add(tag);
            Context.SaveChanges();
        }

        public List<Entidades.Tag> ObterTodasPorUsuario(Guid codigoUsuario)
        {
            var tagsUsuario = Context.Tags
                .Where(t => t.CodigoUsuario == codigoUsuario)
                .ToList();

            return tagsUsuario;
        }
    }
}
