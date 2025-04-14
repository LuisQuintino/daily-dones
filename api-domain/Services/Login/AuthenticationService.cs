using api_domain.Extensions;
using api_domain.Repositories.Usuario;
using Azure.Identity;

namespace api_domain.Services.Login
{
    public class AuthenticationService(IUsuarioRepository usuarioRepository) : IAuthenticationService
    {
        private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

        public string Autenticar(string email, string senha)
        {
            var usuario =
                _usuarioRepository.ObterPorEmail(email)
                ?? throw new ArgumentException();

            if (!StringCipher.CompareHash(usuario.Senha, senha))
                throw new AuthenticationFailedException("Senha ou Email incorretos");

            return JwtExtensions.GerarToken(usuario);
        }
    }
}
