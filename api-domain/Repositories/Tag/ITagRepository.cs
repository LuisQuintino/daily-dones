namespace api_domain.Repositories.Tag
{
    public interface ITagRepository
    {
        List<Entidades.Tag> ObterTodasPorUsuario(Guid codigoUsuario);
        void Inserir(Entidades.Tag tag);
        Entidades.Tag ObterPorCodigo(Guid codigoTag);
    }
}
