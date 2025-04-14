using api_domain.Entidades;
using api_domain.Messaging.Tarefa;
using api_domain.Services.Tarefa;
using api_domain.Services.Usuario;
using daily_dones_api.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBaseV2
    {

        private readonly ITarefaService _tarefaService;
        private readonly ILogger<TarefaController> _logger;

        public TarefaController(ILogger<TarefaController> logger,
            ITarefaService tarefaService)
        {
            _logger = logger;
            _tarefaService = tarefaService;
        }

        [HttpGet("todas")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTodasTarefasPorUsuario()
        {
            var usuariosTarefa = 
                _tarefaService.ObterTodasPorUsuario(ObterCodigoUsuario());

            return Ok(usuariosTarefa);
        }

        [HttpGet("range")]
        [Authorize]
        public ActionResult<List<Tarefa>> ObterTarefasPorUsuarioRange([FromQuery] ObterTarefaPorRangeRequest obterTarefaPorRangeRequest)
        {
            var tarefasUsuario =
                _tarefaService.ObterPorRangeUsuario(ObterCodigoUsuario(), obterTarefaPorRangeRequest);

            return Ok(tarefasUsuario);
        }

        [HttpPost("inserir")]
        [Authorize]
        public ActionResult Inserir(InserirTarefaRequest inserirTarefaRequest)
        {
            inserirTarefaRequest.CodigoUsuario = ObterCodigoUsuario();

            _tarefaService.Inserir(inserirTarefaRequest);
            return Ok();
        }

        [HttpPut("atualizar")]
        [Authorize]
        public ActionResult Atualizar(AtualizarTarefaRequest atualizarTarefaRequest)
        {
            atualizarTarefaRequest.CodigoUsuario = ObterCodigoUsuario();

            _tarefaService.Atualizar(atualizarTarefaRequest);
            return Ok();
        }
    }
}
