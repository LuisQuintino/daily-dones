using api_domain.Entidades;
using api_domain.Messaging.Authentication;
using api_domain.Services.Login;
using api_domain.Services.Tag;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daily_dones_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger,
            IAuthenticationService authenticationService)
        {
            _logger = logger;
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Inserir(AuthenticationDTO authenticationDTO)
        {
            var token = _authenticationService.Autenticar(authenticationDTO.Email, authenticationDTO.Senha);
            return Ok(token);
        }
    }
}
