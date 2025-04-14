using api_domain.Extensions;
using api_domain.Repositories.Usuario;
using Org.BouncyCastle.Crypto.Generators;

namespace api_domain.Services.Usuario
{
    public class UsuarioService(IUsuarioRepository usuarioRepository) : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

        public void Atualizar(Entidades.Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void Deletar(Entidades.Usuario usuario)
        {
            _usuarioRepository.Delete(usuario);
        }

        public void Inserir(Entidades.Usuario usuario)
        {
            usuario.Codigo = new Guid();
            usuario.Senha = StringCipher.GenerateHash(usuario.Senha);
            _usuarioRepository.Insert(usuario);
        }

        public List<Entidades.Usuario> ObterTodos()
        {
            return _usuarioRepository.GetAll();
        }
    }
}
