using api_domain.Config;
using api_domain.Entidades;

namespace api_domain.Repositories.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public BdContext _context { get; set; }

        public UsuarioRepository(BdContext bdContext)
        {
            _context = bdContext;
        }

        public List<Entidades.Usuario> GetAll()
        {
            var listaUsuarios = _context.Usuarios.ToList();

            return listaUsuarios;
        }

        public void Insert(Entidades.Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Entidades.Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(Entidades.Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public Entidades.Usuario ObterPorEmail(string email)
        {
            return _context.Usuarios.Where(x => x.Email.Equals(email))?.SingleOrDefault();
        }
    }
}
