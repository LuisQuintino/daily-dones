using api_domain.Entidades;
using api_domain.Services.Usuario;
using daily_dones_api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBaseV2
    {

        private readonly IUsuarioService _usuarioService;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger,
            IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Authorize]
        public List<Usuario> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }

        [HttpPost]
        [Authorize]
        public StatusCodeResult Inserir(Usuario usuario)
        {
            _usuarioService.Inserir(usuario);

            return Ok();
        }

		[HttpPut]
        [Authorize]
        public StatusCodeResult Atualizar(Usuario usuario)
		{
			_usuarioService.Atualizar(usuario);

			return Ok();
		}

		[HttpDelete]
        [Authorize]
        public StatusCodeResult Deletar(Usuario usuario)
		{
			_usuarioService.Deletar(usuario);

			return Ok();
		}
	}
}
