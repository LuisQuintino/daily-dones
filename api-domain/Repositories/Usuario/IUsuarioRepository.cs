namespace api_domain.Repositories.Usuario
{
    public interface IUsuarioRepository
    {
        public List<Entidades.Usuario> GetAll();
        public void Insert(Entidades.Usuario usuario);
        public void Update(Entidades.Usuario usuario);
        public void Delete(Entidades.Usuario usuario);

        public Entidades.Usuario ObterPorEmail(string email);
    }
}
