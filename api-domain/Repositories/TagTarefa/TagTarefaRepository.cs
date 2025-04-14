using api_domain.Config;

namespace api_domain.Repositories.TagTarefa
{
    public class TagTarefaRepository(BdContext context) : ITagTarefaRepository
    {
        private readonly BdContext _context = context;

        public void Deletar(Entidades.TagTarefa tagTarefa)
        {
            _context.TagTarefas.Remove(tagTarefa);
            _context.SaveChanges();
        }

        public void Inserir(Entidades.TagTarefa tagTarefa)
        {
            _context.TagTarefas.Add(tagTarefa);
            _context.SaveChanges();
        }
    }
}
