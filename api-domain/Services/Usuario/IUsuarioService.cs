namespace api_domain.Services.Usuario
{
    public interface IUsuarioService
    {
        public List<Entidades.Usuario> ObterTodos();
        public void Inserir(Entidades.Usuario usuario);
        public void Atualizar(Entidades.Usuario usuario);
        public void Deletar(Entidades.Usuario usuario);
    }
}
