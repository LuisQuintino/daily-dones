using api_domain.Entidades;
using api_domain.Services.Tag;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : ControllerBase
    {

        private readonly ITagService _tagService;
        private readonly ILogger<TagController> _logger;

        public TagController(ILogger<TagController> logger,
            ITagService tagService)
        {
            _logger = logger;
            _tagService = tagService;
        }

        [HttpGet("todas/{codigoUsuario}")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTodasTagsPorUsuario(Guid codigoUsuario)
        {
            var usuariosTarefa =
                _tagService.ObterTodasPorUsuario(codigoUsuario);

            return Ok(usuariosTarefa);
        }

        [HttpPost("inserir")]
        [Authorize]
        public ActionResult Inserir(Tag tag)
        {
            _tagService.Inserir(tag);
            return Ok();
        }
    }
}
