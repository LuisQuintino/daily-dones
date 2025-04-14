using api_domain.Entidades;
using api_domain.Messaging.Tarefa;
using api_domain.Services.Tarefa;
using api_domain.Services.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {

        private readonly ITarefaService _tarefaService;
        private readonly ILogger<TarefaController> _logger;

        public TarefaController(ILogger<TarefaController> logger,
            ITarefaService tarefaService)
        {
            _logger = logger;
            _tarefaService = tarefaService;
        }

        [HttpGet("todas/{codigoUsuario}")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTodasTarefasPorUsuario(Guid codigoUsuario)
        {
            var usuariosTarefa = 
                _tarefaService.ObterTodasPorUsuario(codigoUsuario);

            return Ok(usuariosTarefa);
        }

        [HttpGet("range/{codigoUsuario}")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTarefasPorUsuarioRange(Guid codigoUsuario, [FromQuery] ObterTarefaPorRangeRequest obterTarefaPorRangeRequest)
        {
            var tarefasUsuario =
                _tarefaService.ObterPorRangeUsuario(codigoUsuario, obterTarefaPorRangeRequest);

            return Ok(tarefasUsuario);
        }

        [HttpPost("inserir")]
        [Authorize]
        public ActionResult Inserir(InserirTarefaRequest inserirTarefaRequest)
        {
            _tarefaService.Inserir(inserirTarefaRequest);
            return Ok();
        }
    }
}
