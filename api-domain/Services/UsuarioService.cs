using api_domain.Entidades;
using api_domain.Repositories;

namespace api_domain.Services
{
	public class UsuarioService : IUsuarioService
	{
		IUsuarioRepository _usuarioRepository;

		public UsuarioService(IUsuarioRepository usuarioRepository)
		{
			_usuarioRepository = usuarioRepository;
		}

		public void Atualizar(Usuario usuario)
		{
			_usuarioRepository.Update(usuario);
		}

		public void Deletar(Usuario usuario)
		{
			_usuarioRepository.Delete(usuario);
		}

		public void Inserir(Usuario usuario)
		{
			_usuarioRepository.Insert(usuario);
		}

		public List<Usuario> ObterTodos()
		{
			return _usuarioRepository.GetAll();
		}
	}
}
