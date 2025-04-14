namespace api_domain.Services.TagTarefas
{
    public interface ITagTarefasService
    {
        void Inserir(Entidades.TagTarefa tagTarefa);
        void Deletar(Entidades.TagTarefa tagTarefa);
    }
}
