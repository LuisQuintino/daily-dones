using api_domain.Entidades;
using api_domain.Services.TagTarefas;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagTarefasController : ControllerBase
    {

        private readonly ITagTarefasService _tagTarefasService;
        private readonly ILogger<TagTarefasController> _logger;

        public TagTarefasController(ILogger<TagTarefasController> logger,
            ITagTarefasService tagTarefasService)
        {
            _logger = logger;
            _tagTarefasService = tagTarefasService;
        }

        [HttpPost("inserir")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTodasTagsPorUsuario(TagTarefa tagTarefa)
        {
            _tagTarefasService.Inserir(tagTarefa);
            return Ok();
        }

        [HttpDelete("remover")]
        [Authorize]
        public ActionResult Inserir(TagTarefa tagTarefa)
        {
            _tagTarefasService.Deletar(tagTarefa);
            return Ok();
        }
    }
}
