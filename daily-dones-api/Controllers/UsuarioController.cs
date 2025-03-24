using api_domain.Entidades;
using api_domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
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
        public List<Usuario> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }

        [HttpPost]
        public StatusCodeResult Inserir(Usuario usuario)
        {
            _usuarioService.Inserir(usuario);

            return Ok();
        }

		[HttpPut]
		public StatusCodeResult Atualizar(Usuario usuario)
		{
			_usuarioService.Atualizar(usuario);

			return Ok();
		}

		[HttpDelete]
		public StatusCodeResult Deletar(Usuario usuario)
		{
			_usuarioService.Deletar(usuario);

			return Ok();
		}
	}
}
