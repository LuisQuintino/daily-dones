namespace api_domain.Repositories.TagTarefa
{
    public interface ITagTarefaRepository
    {
        void Inserir(Entidades.TagTarefa tagTarefa);
        void Deletar(Entidades.TagTarefa tagTarefa);
        List<Entidades.TagTarefa> ObterTodasPorTarefa(Guid codigoTarefa);
    }
}
