using api_domain.Entidades;
using api_domain.Services.Tag;
using daily_dones_api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : ControllerBaseV2
    {

        private readonly ITagService _tagService;
        private readonly ILogger<TagController> _logger;

        public TagController(ILogger<TagController> logger,
            ITagService tagService)
        {
            _logger = logger;
            _tagService = tagService;
        }

        [HttpGet("todas")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTodasTagsPorUsuario()
        {
            var usuariosTarefa =
                _tagService.ObterTodasPorUsuario(ObterCodigoUsuario());

            return Ok(usuariosTarefa);
        }

        [HttpPost("inserir")]
        [Authorize]
        public ActionResult Inserir(Tag tag)
        {
            tag.CodigoUsuario = ObterCodigoUsuario();

            _tagService.Inserir(tag);
            return Ok();
        }
    }
}
