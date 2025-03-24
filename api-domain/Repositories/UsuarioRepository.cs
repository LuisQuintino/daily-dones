using api_domain.Config;
using api_domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace api_domain.Repositories
{
	public class UsuarioRepository : IUsuarioRepository
	{
		public BdContext _context { get; set; }

		public UsuarioRepository(BdContext bdContext)
		{
			_context = bdContext;
		}

		public List<Usuario> GetAll()
		{
			var listaUsuarios = _context.Usuarios.ToList();

			return listaUsuarios;
		}

		public void Insert(Usuario usuario)
		{
			_context.Usuarios.Add(usuario);
			_context.SaveChanges();
		}

		public void Update(Usuario usuario)
		{
			_context.Usuarios.Update(usuario);
			_context.SaveChanges();
		}

		public void Delete(Usuario usuario)
		{
			_context.Usuarios.Remove(usuario);
			_context.SaveChanges();
		}
	}
}
