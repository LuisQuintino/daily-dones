namespace api_domain.Services.Tag
{
    public interface ITagService
    {
        List<Entidades.Tag> ObterTodasPorUsuario(Guid codigoUsuario);
        void Inserir(Entidades.Tag tag);
    }
}
