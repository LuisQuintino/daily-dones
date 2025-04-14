namespace api_domain.Services.TagTarefas
{
    public interface ITagTarefasService
    {
        void Inserir(Entidades.TagTarefa tagTarefa);
        void Deletar(Entidades.TagTarefa tagTarefa);
        List<Entidades.TagTarefa> ObterTodasPorTarefa(Guid codigoTarefa, Guid codigoUsuario);
    }
}
